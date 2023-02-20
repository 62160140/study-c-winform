namespace C__WinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        button.Click +=  button_Click; // += คือการเพิ่ม Event ให้ปุ่ม
    }

    private void button_Click(object sender, EventArgs e)
    {
        int a = int.Parse(textBox1.Text);
        int b = int.Parse(textBox2.Text);
        int sum = a + b;
        labelResult.Text = $"ผลลัพธ์ : {a}+{b} = {sum}";
        
    }
}
