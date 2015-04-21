using System.Windows.Forms;
using System.Threading;

var gui = Require<Gui>();

var f = gui.PopUp();

f.TopMost = true;

f.Sta += delegate {
	var button = new Button();
	button.Width = 75;
	button.Height = 50;
	f.Controls.Add(button);
};

f.Sta.Start();

f.Sta.Enqueue(delegate() {
	var label = new Label();
	label.Top = 20;	
	label.Left = 20;
	label.Text = "Hello from a PopUp.";
	label.Dock = DockStyle.Fill;
	f.Controls.Add(label);
	var t = new Thread(new ThreadStart(
	delegate{
		while(true) {
			label.Text = DateTime.Now.ToLongTimeString();
			Thread.Sleep(1000);
		}}));
	t.IsBackground = true;
	t.Start();
});

//var button = (Button)f.Controls[0];
//button.BackColor = System.Drawing.Color.Red;
//button.Click += new System.EventHandler((sender, eventArgs) => Console.WriteLine("Button was Clickked"));
