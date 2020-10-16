using Atomus.Diagnostics;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Atomus.Control.ErrorAlert
{
    public class ErrorAlertAdapter : IErrorAlert
    {
        private IErrorAlert errorAlert;
        
        bool IErrorAlert.Result
        {
            get
            {
                return this.errorAlert.Result;
            }
            set
            {
                this.errorAlert.Result = value;
            }
        }
        ErrorBlinkStyle IErrorAlert.BlinkStyle
        {
            get
            {
                return this.errorAlert.BlinkStyle;
            }
            set
            {
                this.errorAlert.BlinkStyle = value;
            }
        }
        Icon IErrorAlert.Icon
        {
            get
            {
                return this.errorAlert.Icon;
            }
            set
            {
                this.errorAlert.Icon = value;
            }
        }
        ErrorIconAlignment IErrorAlert.IconAlignment
        {
            get
            {
                return this.errorAlert.IconAlignment;
            }
            set
            {
                this.errorAlert.IconAlignment = value;
            }
        }
        int IErrorAlert.IconPadding
        {
            get
            {
                return this.errorAlert.IconPadding;
            }
            set
            {
                this.errorAlert.IconPadding = value;
            }
        }
        int IErrorAlert.BlinkRate
        {
            get
            {
                return this.errorAlert.BlinkRate;
            }
            set
            {
                this.errorAlert.BlinkRate = value;
            }
        }
        
        void IErrorAlert.ControlIconAlignment(System.Windows.Forms.Control control)
        {
            this.errorAlert.ControlIconAlignment(control);
        }
        void IErrorAlert.ControlIconAlignment(System.Windows.Forms.Control control, ErrorIconAlignment _ErrorIconAlignment)
        {
            this.errorAlert.ControlIconAlignment(control, _ErrorIconAlignment);
        }

        void IErrorAlert.ControlIconPadding(System.Windows.Forms.Control control)
        {
            this.errorAlert.ControlIconPadding(control);
        }
        void IErrorAlert.ControlIconPadding(System.Windows.Forms.Control control, int iconPadding)
        {
            this.errorAlert.ControlIconPadding(control, iconPadding);
        }

        public ErrorAlertAdapter() { }


        private void CreateErrorAlert(params System.Windows.Forms.Control[] controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                if (control != null)
                {
                    this.CreateErrorAlert(control.GetType().FullName);
                    break;
                }
            }
        }
        private void CreateErrorAlert(string typeFullName)
        {
            if (this.errorAlert == null)
            {
                this.errorAlert = (IErrorAlert)Factory.CreateInstance(this.GetAttribute(typeFullName), false, true);
                this.errorAlert.Clear();
            }
        }

        void IErrorAlert.SetError(System.Windows.Forms.Control control)
        {
            this.CreateErrorAlert(control);

            this.errorAlert.SetError(control);
        }

        void IErrorAlert.SetError(System.Windows.Forms.Control control, string message)
        {
            this.CreateErrorAlert(control);

            this.errorAlert.SetError(control, message);
        }

        void IErrorAlert.Clear()
        {
            this.errorAlert?.Clear();
        }

        void IErrorAlert.Clear(System.Windows.Forms.Control control)
        {
            this.errorAlert?.Clear(control);
        }

        bool IErrorAlert.TextEqual(string value, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextEqual(value, controls);
        }
        bool IErrorAlert.TextEqual(string value, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextEqual(value, message, controls);
        }

        bool IErrorAlert.TextNotEqual(string value, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextNotEqual(value, controls);
        }
        bool IErrorAlert.TextNotEqual(string value, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextNotEqual(value, message, controls);
        }

        bool IErrorAlert.TextLengthEqual(int length, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthEqual(length, controls);
        }
        bool IErrorAlert.TextLengthEqual(int length, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthEqual(length, message, controls);
        }

        bool IErrorAlert.TextLengthLessThan(int length, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthLessThan(length, controls);
        }
        bool IErrorAlert.TextLengthLessThan(int length, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthLessThan(length, message, controls);
        }

        bool IErrorAlert.TextLengthLessThanOrEqual(int length, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthLessThanOrEqual(length, controls);
        }
        bool IErrorAlert.TextLengthLessThanOrEqual(int length, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthLessThanOrEqual(length, message, controls);
        }

        bool IErrorAlert.TextLengthGreaterThan(int length, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthGreaterThan(length, controls);
        }
        bool IErrorAlert.TextLengthGreaterThan(int length, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthGreaterThan(length, message, controls);
        }

        bool IErrorAlert.TextLengthGreaterThanOrEqual(int length, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthGreaterThanOrEqual(length, controls);
        }
        bool IErrorAlert.TextLengthGreaterThanOrEqual(int length, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextLengthGreaterThanOrEqual(length, message, controls);
        }

        bool IErrorAlert.TextContains(string value, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextContains(value, controls);
        }
        bool IErrorAlert.TextContains(string value, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextContains(value, message, controls);
        }

        bool IErrorAlert.TextNotContains(string value, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextNotContains(value, controls);
        }
        bool IErrorAlert.TextNotContains(string value, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextNotContains(value, message, controls);
        }

        bool IErrorAlert.TextStartsWith(string value, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextStartsWith(value, controls);
        }
        bool IErrorAlert.TextStartsWith(string value, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextStartsWith(value, message, controls);
        }

        bool IErrorAlert.TextEndsWith(string value, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextEndsWith(value, controls);
        }
        bool IErrorAlert.TextEndsWith(string value, string message, params System.Windows.Forms.Control[] controls)
        {
            this.CreateErrorAlert(controls);

            return this.errorAlert.TextEndsWith(value, message, controls);
        }

        bool IErrorAlert.ValueEqual(decimal value, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueEqual(value, numericUpDowns);
        }
        bool IErrorAlert.ValueEqual(decimal value, string message, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueEqual(value, message, numericUpDowns);
        }

        bool IErrorAlert.ValueLessThan(decimal value, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueLessThan(value, numericUpDowns);
        }
        bool IErrorAlert.ValueLessThan(decimal value, string message, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueLessThan(value, message, numericUpDowns);
        }

        bool IErrorAlert.ValueLessThanOrEqual(decimal value, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueLessThanOrEqual(value, numericUpDowns);
        }
        bool IErrorAlert.ValueLessThanOrEqual(decimal value, string message, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueLessThanOrEqual(value, message, numericUpDowns);
        }

        bool IErrorAlert.ValueGreaterThan(decimal value, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueGreaterThan(value, numericUpDowns);
        }
        bool IErrorAlert.ValueGreaterThan(decimal value, string message, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueGreaterThan(value, message, numericUpDowns);
        }

        bool IErrorAlert.ValueGreaterThanOrEqual(decimal value, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueGreaterThanOrEqual(value, numericUpDowns);
        }
        bool IErrorAlert.ValueGreaterThanOrEqual(decimal value, string message, params System.Windows.Forms.Control[] numericUpDowns)
        {
            this.CreateErrorAlert(numericUpDowns);

            return this.errorAlert.ValueGreaterThanOrEqual(value, message, numericUpDowns);
        }

        bool IErrorAlert.Checked(params System.Windows.Forms.Control[] checkBoxs)
        {
            this.CreateErrorAlert(checkBoxs);

            return this.errorAlert.Checked(checkBoxs);
        }
        bool IErrorAlert.Checked(string message, params System.Windows.Forms.Control[] checkBoxs)
        {
            this.CreateErrorAlert(checkBoxs);

            return this.errorAlert.Checked(message, checkBoxs);
        }

        bool IErrorAlert.UnChecked(params System.Windows.Forms.Control[] checkBoxs)
        {
            this.CreateErrorAlert(checkBoxs);

            return this.errorAlert.UnChecked(checkBoxs);
        }
        bool IErrorAlert.UnChecked(string message, params System.Windows.Forms.Control[] checkBoxs)
        {
            this.CreateErrorAlert(checkBoxs);

            return this.errorAlert.UnChecked(message, checkBoxs);
        }
    }
}