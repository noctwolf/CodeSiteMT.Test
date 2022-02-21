using Raize.CodeSiteLogging;
using System;

namespace CodeSiteMT.Test
{
    public class 表达式测试
    {
        private string _完整表达式属性 = "完整表达式属性";
        private string _完整属性 = "完整属性";

        public string 只读表达式属性 => "只读表达式属性";

        public string 自动属性 { get; set; } = "自动属性";

        public string 只读自动属性 { get; } = "只读自动属性";

        public string 只读属性
        {
            get
            {
                return "只读属性";
            }
        }

        public string 完整属性
        {
            get { return _完整属性; }
            set
            {
                _完整属性 = value;
            }
        }

        public string 完整表达式属性 { get => _完整表达式属性; set => _完整表达式属性 = value; }

        string 表达式方法() => "表达式方法";

        void 无返回值表达式方法() => 表达式方法();

        string 方法()
        {
            return "方法";
        }

        void 无返回值方法()
        {
            方法();
        }
    }
}
