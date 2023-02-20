namespace C__WinForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(350, 350);
        this.Text = "Form1";


        // สร้างปุ่ม
        button = new Button(); 
        button.Name = "sumButton"; // ตั้งชื่อปุ่ม
        button.Text = "บวกเลข"; // ตั้งข้อความปุ่ม
        button.Location = new System.Drawing.Point(100, 250); // ตำแหน่งปุ่ม
        button.Size = new System.Drawing.Size(150,40 ); // ขนาดปุ่ม
        

        // สร้าง Label 1
        label1 = new Label();
        label1.Text = "ตัวเลขที่ 1";
        label1.Location = new System.Drawing.Point(100, 10);
        label1.Size = new System.Drawing.Size(150, 40);

        // สร้าง TextBox 1
        textBox1 = new TextBox();
        textBox1.Name = "dataA";
        textBox1.Location = new System.Drawing.Point(100, 50);
        textBox1.Size = new System.Drawing.Size(150, 40);
        textBox1.Text = "0";

        // สร้าง Label 2
        label2 = new Label();
        label2.Text = "ตัวเลขที่ 2";
        label2.Location = new System.Drawing.Point(100, 120);
        label2.Size = new System.Drawing.Size(150, 40);

        // สร้าง TextBox 2
        textBox2 = new TextBox();
        textBox2.Name = "dataB";
        textBox2.Location = new System.Drawing.Point(100, 150);
        textBox2.Size = new System.Drawing.Size(150, 40);
        textBox2.Text = "0";


        // สร้าง Label ผลลัพธ์
        labelResult = new Label();
        labelResult.Text = "ผลลัพธ์";
        labelResult.Location = new System.Drawing.Point(100, 200);
        labelResult.Size = new System.Drawing.Size(150, 40);

      

        // เพิ่มปุ่มในฟอร์ม
        this.Controls.Add(button);
        this.Controls.Add(textBox1);
        this.Controls.Add(textBox2);
        this.Controls.Add(label1);
        this.Controls.Add(label2);
        this.Controls.Add(labelResult);
    }

    private Button button; // Button
    private TextBox textBox1;
    private TextBox textBox2;

    private Label label1, label2, labelResult;

    #endregion
}
