using ApiDashboard.Model;

namespace ApiDashboard.Respository
{
    public static class ProductRepository
    {

        public static readonly List<Product> Products = new List<Product>()
        {
            new Product {
                Id = 0,
                Price = 120,
                Name = "Teclado Mecânico RGB",
                Description = "Teclado com switches azuis, iluminação RGB e estrutura em alumínio."
            },
            new Product {
                Id = 1,
                Price = 80,
                Name = "Mouse Gamer",
                Description = "Mouse com 6 botões programáveis e sensor de alta precisão."
            },
            new Product {
                Id = 2,
                Price = 250,
                Name = "Monitor 24'' Full HD",
                Description = "Monitor LED com resolução 1920x1080 e taxa de atualização de 75Hz."
            },
            new Product {
                Id = 3,
                Price = 45,
                Name = "Headset P2 com Microfone",
                Description = "Headset estéreo com microfone integrado e almofadas confortáveis."
            },
            new Product {
                Id = 4,
                Price = 300,
                Name = "Cadeira Gamer",
                Description = "Cadeira com ajuste de altura, encosto reclinável e apoio para braços."
            },
            new Product {
                Id = 5,
                Price = 90,
                Name = "Webcam HD 1080p",
                Description = "Webcam com microfone embutido e captura de vídeo em alta definição."
            },
            new Product {
                Id = 6,
                Price = 150,
                Name = "HD Externo 1TB",
                Description = "Disco rígido portátil USB 3.0 com 1TB de capacidade de armazenamento."
            },
            new Product {
                Id = 7,
                Price = 60,
                Name = "Carregador Wireless",
                Description = "Carregador por indução compatível com dispositivos Qi."
            },
            new Product {
                Id = 8,
                Price = 40,
                Name = "Hub USB 4 Portas",
                Description = "Hub com 4 entradas USB 3.0 de alta velocidade."
            },
            new Product {
                Id = 9,
                Price = 110,
                Name = "Teclado e Mouse Sem Fio",
                Description = "Combo com alcance de até 10 metros e conexão via receptor USB."
            }
        };

        public static async Task<List<Product>> FindAllProducts()
        {
            await Task.Delay(100);
            return Products;
        }
    }
}
