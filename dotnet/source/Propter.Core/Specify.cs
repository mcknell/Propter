using System;
using System.Linq.Expressions;

namespace Propter.Core
{
    public static class Specify
    {
        public static string /*ISubjectBuilder<THost>*/ For<THost>(Expression<Func<THost>> expression)
        {
            return ""/*new SubjectBuilder<THost>()*/;
        }
    }
}
