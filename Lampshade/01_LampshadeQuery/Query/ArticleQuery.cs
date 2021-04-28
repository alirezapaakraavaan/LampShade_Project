using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Comment;
using BlogManagement.Infrastructure.EFCore;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        private readonly CommentContext _commentContext;

        public ArticleQuery(BlogContext context, CommentContext commentContext)
        {
            _context = context;
            _commentContext = commentContext;
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
                        Id = x.Id,
                        CategoryName = x.ArticleCategory.Name,
                        CategorySlug = x.ArticleCategory.Slug,
                        Slug = x.Slug,
                        CanonicalAddress = x.CanonicalAddress,
                        Description = x.Description,
                        KeyWords = x.Keywords,
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

            var comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Article)
                .Where(x => x.OwnerRecordId == article.Id).ToList()
                .Select(x => new CommentQueryModel
                {
                    Name = x.Name,
                    Message = x.Message,
                    Id = x.Id,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi()
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var comment in comments)
            {
                if (comment.ParentId > 0)
                    comment.parentName = comments.FirstOrDefault(x => x.Id == comment.ParentId)?.Name;
            }

            article.Comments = comments;

            return article;
        }
    }
}