
// This file has been generated by the GUI designer. Do not modify.
namespace NepConSharp
{
	public partial class LoginWindow
	{
		private global::Gtk.Fixed fixedLayout;
		private global::Gtk.Table table3;
		private global::Gtk.ComboBox cbxLocation;
		private global::Gtk.Label lblLocation;
		private global::Gtk.Label lblName;
		private global::Gtk.Label lblPassword;
		private global::Gtk.Entry tbxName;
		private global::Gtk.Entry tbxPassword;
		private global::Gtk.Button btnLogin;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget NepConSharp.LoginWindow
			this.Name = "NepConSharp.LoginWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("NepConnect Login");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child NepConSharp.LoginWindow.Gtk.Container+ContainerChild
			this.fixedLayout = new global::Gtk.Fixed ();
			this.fixedLayout.Name = "fixedLayout";
			this.fixedLayout.HasWindow = false;
			// Container child fixedLayout.Gtk.Fixed+FixedChild
			this.table3 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.cbxLocation = global::Gtk.ComboBox.NewText ();
			this.cbxLocation.AppendText (global::Mono.Unix.Catalog.GetString ("Default"));
			this.cbxLocation.Name = "cbxLocation";
			this.cbxLocation.Active = 0;
			this.table3.Add (this.cbxLocation);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3 [this.cbxLocation]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblLocation = new global::Gtk.Label ();
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.LabelProp = global::Mono.Unix.Catalog.GetString ("Location");
			this.lblLocation.Justify = ((global::Gtk.Justification)(1));
			this.table3.Add (this.lblLocation);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblLocation]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblName = new global::Gtk.Label ();
			this.lblName.Name = "lblName";
			this.lblName.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.lblName.Justify = ((global::Gtk.Justification)(1));
			this.table3.Add (this.lblName);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblName]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblPassword = new global::Gtk.Label ();
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
			this.lblPassword.Justify = ((global::Gtk.Justification)(1));
			this.table3.Add (this.lblPassword);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblPassword]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.tbxName = new global::Gtk.Entry ();
			this.tbxName.CanFocus = true;
			this.tbxName.Name = "tbxName";
			this.tbxName.IsEditable = true;
			this.tbxName.InvisibleChar = '●';
			this.table3.Add (this.tbxName);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3 [this.tbxName]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.tbxPassword = new global::Gtk.Entry ();
			this.tbxPassword.CanFocus = true;
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.IsEditable = true;
			this.tbxPassword.Visibility = false;
			this.tbxPassword.InvisibleChar = '●';
			this.table3.Add (this.tbxPassword);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.tbxPassword]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.fixedLayout.Add (this.table3);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixedLayout [this.table3]));
			w7.X = 9;
			w7.Y = 9;
			// Container child fixedLayout.Gtk.Fixed+FixedChild
			this.btnLogin = new global::Gtk.Button ();
			this.btnLogin.CanFocus = true;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.UseUnderline = true;
			this.btnLogin.Label = global::Mono.Unix.Catalog.GetString ("Login");
			this.fixedLayout.Add (this.btnLogin);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixedLayout [this.btnLogin]));
			w8.X = 190;
			w8.Y = 116;
			this.Add (this.fixedLayout);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnLogin.Clicked += new global::System.EventHandler (this.OnLoginClickedEvent);
		}
	}
}