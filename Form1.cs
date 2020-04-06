using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ChangeQueryText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            changer = new Changer();
            InitializeComponent();
            Bind();
        }
        public Changer changer;
   
        private void Bind()
        {
            textBoxQuery.DataBindings.Add("Text", changer, "QueryText");
            textBoxTemplate.DataBindings.Add("Text", changer, "TemplateText");
            checkBoxOnlyComment.DataBindings.Add("Checked", changer, "OnlyComment");
        }

        private void buttonTemplateToQuery_Click(object sender, EventArgs e)
        {
            changer.ChangeText(Direction.TemplateToQuery);
        }

        private void buttonQueryToTemplate_Click(object sender, EventArgs e)
        {
            changer.ChangeText(Direction.QueryToTemplate);
        }

        private void checkBoxOnlyComment_CheckedChanged(object sender, EventArgs e)
        {
            string titleTextToQuery;
            if (checkBoxOnlyComment.Checked)
            {
                titleTextToQuery = "Удалить комментарии из текста макета -->";
            }
            else
            {
                titleTextToQuery = "Текст макета в запрос -->";
            }

            buttonTemplateToQuery.Text = titleTextToQuery;
            buttonQueryToTemplate.Visible = !checkBoxOnlyComment.Checked;
        }
    }

    public enum Direction
    {
        TemplateToQuery,
        QueryToTemplate
    }

    public class Changer:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool OnlyComment
        {
            get { return onlyComment; }
            set
            {
                if (onlyComment != value)
                {
                    onlyComment = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string QueryText {
            get { return queryText; }
            set {
                if (queryText != value)
                {
                    queryText = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string TemplateText
        {
            get { return templateText; }
            set {
                if (templateText != value)
                {
                    templateText = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private bool onlyComment = false;
        private string queryText;
        private string templateText;

        private string columnNameTemplate = "Template";
        private string columnNameQuery    = "Query";

        private DataTable relations;

        public Changer()
        {
            relations = new DataTable();
            var StringType = "".GetType();
            relations.Columns.Add(columnNameTemplate, StringType);
            relations.Columns.Add(columnNameQuery, StringType);

            relations.Rows.Add("\r\n|", "\r\n");
            relations.Rows.Add("&gt;", ">");
            relations.Rows.Add("&lt;", "<");
            relations.Rows.Add("&amp;", "&");
            relations.Rows.Add("\"\"", "\"");
        }

        public void ChangeText(Direction direction)
        {
            string columnNameIn;
            string columnNameOut;
            string textIn;
            string textOut;
            switch (direction)
            {
                case Direction.TemplateToQuery:
                    columnNameIn  = columnNameTemplate;
                    columnNameOut = columnNameQuery;

                    textIn = RemoveComment(templateText);

                    if (onlyComment)                    
                        textOut = textIn;
                    else                    
                        textOut = ChangeQuqryText(textIn, columnNameIn, columnNameOut);

                    QueryText = textOut;
                    break;

                case Direction.QueryToTemplate:
                    columnNameIn  = columnNameQuery;
                    columnNameOut = columnNameTemplate;
                    textIn  = queryText;

                    textOut = ChangeQuqryText(textIn, columnNameIn, columnNameOut);
                    TemplateText = textOut;
                    break;

                default:
                    return;
            }

      }

        private string RemoveComment(string text)
        {
            var beginComment = "<!--";
            var endComment   = "-->\r\n";

            var beginIndex = text.IndexOf(beginComment);
            if (beginIndex == -1)
                return text;

            var endIndex = -1;

            var comments = new List<string>();

            while(beginIndex != -1)
            {
                endIndex = text.IndexOf(endComment, beginIndex);
                if (endIndex == -1)
                    endIndex = text.Length;
                else
                    endIndex += endComment.Length;
                var commentLength = endIndex - beginIndex;
                comments.Add(text.Substring(beginIndex, commentLength));

                beginIndex = text.IndexOf(beginComment, endIndex);
            }

            comments = comments.Distinct().ToList();

            foreach(var comment in comments)
            {
                text = text.Replace(comment, "");
            }

            return text;
        }

        private string ChangeQuqryText(string text, string columnNameIn, string columnNameOut)
        {
            foreach (DataRow row in relations.Rows)
            {
                var before = row.Field<string>(columnNameIn);
                var after = row.Field<string>(columnNameOut);
                text = text.Replace(before, after);
            }
            return text;
        }
    }
}
