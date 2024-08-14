using LocalizationDemo.Models;
using static LocalizationDemo.Models.Enum;

namespace LocalizationDemo.Services
{
    public class PageService : IPageService
    {
        private readonly List<Page> _pages;
        private readonly List<PageLayout> _pageLayout;

        public PageService()
        {
            _pages =  new List<Page>
            {
                new Page {Id = 1, Name = "Login"},
                new Page {Id = 2, Name = "Register"},
                new Page {Id = 3, Name = "Home"},
                new Page {Id = 4, Name = "CustomerListing"},
                new Page {Id = 4, Name = "CrossSell"},

            };

            _pageLayout = new List<PageLayout>
            {
                new PageLayout {Id = 1, PageId = 1, key = "UserName", Value = "أسم المستخدم" , Language = Language.AR},
                new PageLayout {Id = 2, PageId = 1, key = "Password", Value = "كلمة السر" , Language = Language.AR},
                new PageLayout {Id = 3, PageId = 1, key = "Login", Value = "تسجيل الدخول" , Language = Language.AR},

                new PageLayout {Id = 4, PageId = 1, key = "UserName", Value = "ユーザー名" , Language = Language.JP},
                new PageLayout {Id = 5, PageId = 1, key = "Password", Value = "パスワード" , Language = Language.JP},
                new PageLayout {Id = 6, PageId = 1, key = "Login", Value = "ログイン" , Language = Language.JP},

                new PageLayout {Id = 7, PageId = 1, key = "UserName", Value = "UserName" , Language = Language.EN},
                new PageLayout {Id = 8, PageId = 1, key = "Password", Value = "Password" , Language = Language.EN},
                new PageLayout {Id = 9, PageId = 1, key = "Login", Value = "Login" , Language = Language.EN},


                new PageLayout {Id = 10, PageId = 4, key = "Customers", Value = "العملاء" , Language = Language.AR},
                new PageLayout {Id = 11, PageId = 4, key = "Logs", Value = "السجلات" , Language = Language.AR},
                new PageLayout {Id = 12, PageId = 4, key = "Reports", Value = "التقارير" , Language = Language.AR},
                new PageLayout {Id = 13, PageId = 4, key = "HideFilter", Value = "اخفاء الفلتر" , Language = Language.AR},
                new PageLayout {Id = 14, PageId = 4, key = "Export", Value = "اصدار" , Language = Language.AR},

                new PageLayout {Id = 15, PageId = 4, key = "Customers", Value = "お客様" , Language = Language.JP},
                new PageLayout {Id = 16, PageId = 4, key = "Logs", Value = "ログ" , Language = Language.JP},
                new PageLayout {Id = 17, PageId = 4, key = "Reports", Value = "レポート" , Language = Language.JP},
                new PageLayout {Id = 18, PageId = 4, key = "HideFilter", Value = "フィルターを非表示にする" , Language = Language.JP},
                new PageLayout {Id = 19, PageId = 4, key = "Export", Value = "輸出" , Language = Language.JP},

                new PageLayout {Id = 20, PageId = 4, key = "Customers", Value = "Customers" , Language = Language.EN},
                new PageLayout {Id = 21, PageId = 4, key = "Logs", Value = "Logs" , Language = Language.EN},
                new PageLayout {Id = 22, PageId = 4, key = "Reports", Value = "Reports" , Language = Language.EN},
                new PageLayout {Id = 23, PageId = 4, key = "HideFilter", Value = "HideFilter" , Language = Language.EN},
                new PageLayout {Id = 24, PageId = 4, key = "Export", Value = "Export" , Language = Language.EN},

                new PageLayout {Id = 25, PageId = 2, key = "Title", Value = "Hello World!" , Language = Language.EN},
                new PageLayout {Id = 26, PageId = 2, key = "Description", Value = "welcome from z2data new localization website, we wish you a nice day ☻." , Language = Language.EN},
                new PageLayout {Id = 26, PageId = 2, key = "ShowHome", Value = "Show Home" , Language = Language.EN},

                new PageLayout {Id = 27, PageId = 2, key = "Title", Value = "مرحبا بالعالم!" , Language = Language.AR},
                new PageLayout {Id = 28, PageId = 2, key = "Description", Value = "مرحبا بكم في موقع z2data اللغوى , نتمنى لكم يوما سعيدا." , Language = Language.AR},
                new PageLayout {Id = 26, PageId = 2, key = "ShowHome", Value = "عرض المنزل" , Language = Language.AR},

                new PageLayout {Id = 29, PageId = 2, key = "Title", Value = "こんにちは世界" , Language = Language.JP},
                new PageLayout {Id = 30, PageId = 2, key = "Description", Value = "z2data の新しいローカリゼーション Web サイトへようこそ。良い一日をお過ごしください ☻" , Language = Language.JP},
                new PageLayout {Id = 26, PageId = 2, key = "ShowHome", Value = "サイトへようこそ" , Language = Language.JP},

            };
        }

        public Dictionary<string, string> GetValuesByKeys(List<string> keys, Language language)
        {
            var query = _pageLayout.Where(P=>P.Language == language)
                .Join(keys, p => p.key, k => k, (page, key) => new { Key = page.key, Value = page.Value })
                .ToDictionary(p=>p.Key,p=>p.Value);
            return query;
        }
    }
}
