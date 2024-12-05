using Cliente.Modelos;

namespace Cliente.Servicios.IServicio
{
    public interface IPostsServicio
    {
        public Task<IEnumerable<Post>> GetPosts();
        public Task<Post> GetPosts(int postId);
        public Task<Post> CrearPosts(int post);
        public Task<Post> ActualizarPosts(int postId, Post post);
        public Task<Post> EliminarPosts(int postId);
        public  Task<String> SubidaImagen(MultipartFormDataContent content);


    }
}
