using System.Drawing;
using System.Windows.Forms;
using Transitions;
using Utilidades.Interfaces;

namespace Utilidades
{
    public class showMessageDialog : IAlertas<Form>
    {
        //this colors is for alerts
        private Color GREEN = Color.FromArgb(46, 167, 67);
        private Color RED = Color.FromArgb(215, 58, 73);
        private Color BLUE = Color.FromArgb(31, 111, 235);
        private Color ORANGE = Color.FromArgb(227, 179, 65);

        //Style danger
        public void Danger(Form form, string mensaje)
        {
            form.BackColor = RED;
            Params.Properties(2, mensaje);
            Slide(form);
            form.ShowDialog();
        }

        //Style info
        public void Info(Form form, string mensaje)
        {
            form.BackColor = BLUE;
            Params.Properties(1, mensaje);
            Slide(form);
            form.ShowDialog();
        }

        //Style Succes
        public void Success(Form form, string mensaje)
        {
            form.BackColor = GREEN;
            Params.Properties(1, mensaje);
            Slide(form);
            form.ShowDialog();
        }


        //Style Warning
        public void Warning(Form form, string mensaje)
        {
            form.BackColor = ORANGE;
            Params.Properties(1, mensaje);
            Slide(form);
            form.ShowDialog();
        }

        //Animation for alls alerts
        private void Slide(Form form)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(form, "Top", 20);
            t.add(form, "Left", 160);
            t.run();
        }
    }
}
