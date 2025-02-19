using Models.Models;

namespace Contracts;

public interface IArticleSevice
{
    Task CreateArticle(Article article);
    Task DeleteArticle(int idArticle);
    Task UpdateArticle(Article article);
    Task<IEnumerable<Article>> GetAllArticlesAsync(bool trackChanges);
    Task<Article> GetArticleAsync(int articleId, bool trackChanges);
    Task<IEnumerable<Article>> GetArticlesByIdsAsync(IEnumerable<int> ids, bool trackChanges);
}
