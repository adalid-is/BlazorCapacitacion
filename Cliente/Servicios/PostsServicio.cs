
using Cliente.Helpers;
using Cliente.Modelos;
using Cliente.Servicios.IServicio;
using Newtonsoft.Json;

namespace Cliente.Servicios
{
    public class PostsServicio : IPostsServicio
    {

        private readonly HttpClient _cliente;
        private object JsonCovert;

        public PostsServicio(HttpClient cliente) {

            _cliente = cliente;


        }

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

        public async Task<IEnumerable<Post>> GetPosts(int postId)
        {
            var response = await _cliente.GetAsync($"{Inicializar.UrlBaseApi}/api/posts");
            var content = await response.Content.ReadAsStringAsync();
            var post = JsonConvert.DeserializeObject<IEnumerable<Post>>(content);
            return posts;
        }

        public  Task<Post> GetPosts()
        {
            throw new NotImplementedException();

        }

        public Task<string> SubidaImagen(MultipartFormDataContent content)
        {
            throw new NotImplementedException();
        }
    }
}
