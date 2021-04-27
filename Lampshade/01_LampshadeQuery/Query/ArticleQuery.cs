using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(
                    x => new ArticleQueryModel
                    {
                        Slug = x.Slug,
                        PictureAlt = x.PictureAlt,
                        Picture = x.Picture,
                        PictureTitle = x.PictureTitle,
                        PublishDate = x.PublishDate.ToFarsi(),
                        ShortDescription = x.ShortDescription,
                        Title = x.Title
                    })
                .ToList();
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article = _context.Articles
                .Include(x => x.ArticleCategory)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(
                    x => new ArticleQueryModel
                    {
                        CategoryName = x.ArticleCategory.Name,
                        CategorySlug = x.ArticleCategory.Slug,
                        Slug = x.Slug,
                        CanonicalAddress = x.CanonicalAddress,
                        Description = x.Description,
                        KeyWords = x.KeyWords,
                        MetaDescription = x.MetaDescription,
                        PictureAlt = x.PictureAlt,
                        Picture = x.Picture,
                        PictureTitle = x.PictureTitle,
                        PublishDate = x.PublishDate.ToFarsi(),
                        ShortDescription = x.ShortDescription,
                        Title = x.Title
                    })
                .FirstOrDefault(x => x.Slug == slug);

            if (article != null)
            {
                article.KeywordList = article.KeyWords.Split(",").ToList();
            }

            return article;
        }
    }
}