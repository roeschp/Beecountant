using Accountant.Objects;
using static Accountant.Util.Util;

namespace Accountant.Forms
{
    public static class FormManager
    {
        public static Action<Control>? SelectionClosed;

        public static void CustomerInputClosed(Control tControl)
        {
            SelectionClosed?.Invoke(tControl);
        }
    }
}
