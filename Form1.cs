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

//            changer.PropertyChanged += UpdateField;

        }
        public Changer changer;
   
        private void Bind()
        {
            textBoxQuery.DataBindings.Add("Text", changer, "QueryText");
            textBoxTemplate.DataBindings.Add("Text", changer, "TemplateText");
        }

        private void buttonTemplateToQuery_Click(object sender, EventArgs e)
        {
            changer.ChangeText(Direction.TemplateToQuery);
        }

        private void buttonQueryToTemplate_Click(object sender, EventArgs e)
        {
            changer.ChangeText(Direction.QueryToTemplate);
        }

        private void UpdateField(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "QueryText")
            {
                textBoxQuery.Text = changer.QueryText;
            }
            if (e.PropertyName == "TemplateText")
            {
                textBoxTemplate.Text = changer.TemplateText;
            }
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
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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

        //public event EventHandler<EventArgs> QueryTextChanged;
        //public event EventHandler<EventArgs> TemplateTextChanged;

        private string queryText;
        private string templateText;

        private string columnNameTemplate = "Template";
        private string columnNameQuery    = "Query";

        private DataTable relations = null;

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

 //           QueryTextChanged = new EventHandler<EventArgs>(EventArgs.Empty);
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

                    textIn  = templateText;
 //                   textOut = queryText;
                    break;

                case Direction.QueryToTemplate:
                    columnNameIn  = columnNameQuery;
                    columnNameOut = columnNameTemplate;
                    textIn  = queryText;
 //                   textOut = templateText;
                    break;

                default:
                    return;
            }

            textOut = textIn;
            foreach(DataRow row in relations.Rows)
            {
                var before = row.Field<string>(columnNameIn);
                var after  = row.Field<string>(columnNameOut);
                textOut = textOut.Replace(before, after);
            }

            switch (direction)
            {
                case Direction.TemplateToQuery:
                    QueryText = textOut;
                    break;

                case Direction.QueryToTemplate:
                    TemplateText = textOut;
                    break;

                default:
                    return;
            }
        }

    }
}
