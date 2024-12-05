
using Cliente.Modelos;
using Cliente.Servicios.IServicio;

namespace Cliente.Servicios
{
    public class PostsServicio : IPostsServicio
    {
        public Task<Post> ActualizarPosts(int postId, Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> CrearPosts(int post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> EliminarPosts(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPosts(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<string> SubidaImagen(MultipartFormDataContent content)
        {
            throw new NotImplementedException();
        }
    }
}
