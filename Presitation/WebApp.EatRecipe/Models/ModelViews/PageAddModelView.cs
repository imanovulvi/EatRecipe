using Domen.EatRecipe.Entitys;

namespace WebApp.EatRecipe.Models.ModelViews
{
    public class PageAddModelView
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Aktiv { get; set; }
        public bool IsDeleted { get; set; }

        public static implicit operator Page(PageAddModelView p)
        {
            return new Page {
            Title=p.Title,
            Content=p.Content,
            IsDeleted=p.IsDeleted,
            Aktiv=p.Aktiv
            };
        }
        public static explicit operator PageAddModelView(Page p)
        {
            return new PageAddModelView
            {Title=p.Title,Content=p.Content,IsDeleted=p.IsDeleted,Aktiv=p.Aktiv };

        }
    }
}
