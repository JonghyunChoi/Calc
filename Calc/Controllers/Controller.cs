using Calc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Controllers
{
    public class Controller {
        InputNumber inputNumber = new InputNumber() { Number = 0 };
        UploadNumber uploadNumber = new UploadNumber();
        Operator _operator = new Operator();

        public int InputNumber() {
            return inputNumber.Number;
        }

        public void InputNumber(int value) {
            inputNumber.Number = value;
        }

        public string InputStrNumber() {
            return string.Format("{0:#,###0}", InputNumber());
        }

        public int UploadNumber() {
            return uploadNumber.Number;
        }

        public void UploadNumber(int value) {
            uploadNumber.Number = value;
        }

        public string Operator() {
            return _operator.Type;
        }

        public void Operator(string value) {
            _operator.Type = value;
        }
    }
}
