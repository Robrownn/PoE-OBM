using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoE_OBM.Views.Build
{
    public static class BuildNavPages
    {
        public static string ActivePageKey => "ActivePage";

        public static string Index => "Index";

        public static string CreateNewBuild => "CreateNewBuild";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string CreateNewBuildNavClass(ViewContext viewContext) => PageNavClass(viewContext, CreateNewBuild);

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

        public static void AddActivePage(this ViewDataDictionary viewData, string activePage) => viewData[ActivePageKey] = activePage;
    }
}
