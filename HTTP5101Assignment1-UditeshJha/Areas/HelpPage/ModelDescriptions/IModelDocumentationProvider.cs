using System;
using System.Reflection;

namespace HTTP5101Assignment1_UditeshJha.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}