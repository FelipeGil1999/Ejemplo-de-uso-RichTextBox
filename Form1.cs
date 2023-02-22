namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateMyRichTextBox();
        }


        public void CreateMyRichTextBox()
        {
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Dock = DockStyle.Fill;

            richTextBox1.LoadFile("MyDocument.rtf");
            richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);

            richTextBox1.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Red;

            richTextBox1.SaveFile("MyDocument.rtf", RichTextBoxStreamType.RichText);

            this.Controls.Add(richTextBox1);
        }
    }
}
