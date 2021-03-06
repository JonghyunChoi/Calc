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
        Operator op = new Operator();

        public int InputNumber() {
            return inputNumber.Number;
        }

        public void InputNumber(int value) {
            inputNumber.Number = value;
        }

        public string InputStrNumber() {
            return string.Format("{0:#,###0}", InputNumber());
        }

        public void InputNumberBack() {
            string inputNum = inputNumber.Number.ToString();
            
            if(inputNum.Length > 1) {
                InputNumber(int.Parse(inputNum.Remove(1, 1)));
            } else {
                InputNumber(0);
            }
        }

        public int UploadNumber() {
            return uploadNumber.Number;
        }

        public void UploadNumber(int value) {
            uploadNumber.Number = value;
        }

        public string Operator() {
            return op.Type;
        }

        public void Operator(string value) {
            op.Type = value;
        }

        public void Clear() {
            InputNumber(0);
        }
    }
}
