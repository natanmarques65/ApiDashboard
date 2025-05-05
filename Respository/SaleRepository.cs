using ApiDashboard.Model;

namespace ApiDashboard.Respository
{
    public class SaleRepository
    {
        private static List<Sale> _sales = new List<Sale>(){
            new Sale()
            {
                Id = Guid.NewGuid(),
                Seller = new Seller {
                    Id = 1,
                    Name = "Ana Souza",
                    Email = "ana.souza@example.com",
                    PhoneNumber = "(11) 91234-5678"
                },
                Items = new List<SaleItem>()
                {
                    new SaleItem
                    {
                       Product = new Product
                       {
                           Id = 0,
                           Price = 120,
                           Name = "Teclado Mecânico RGB",
                           Description = "Teclado com switches azuis, iluminação RGB e estrutura em alumínio."
                       },
                       Quantity = 1,
                       Discount = 0
                    },
                    new SaleItem
                    {
                        Product = new Product {
                            Id = 3,
                            Price = 45,
                            Name = "Headset P2 com Microfone",
                            Description = "Headset estéreo com microfone integrado e almofadas confortáveis."
                        },
                        Quantity = 2,
                        Discount = 0
                    }
                }
            },

            new Sale()
            {
                Id = Guid.NewGuid(),
                Seller = new Seller {
                    Id = 1,
                    Name = "Ana Souza",
                    Email = "ana.souza@example.com",
                    PhoneNumber = "(11) 91234-5678"
                },
                Items = new List<SaleItem>()
                {
                    new SaleItem
                    {
                       Product = new Product
                       {
                           Id = 3,
                           Price = 45,
                           Name = "Headset P2 com Microfone",
                           Description = "Headset estéreo com microfone integrado e almofadas confortáveis."
                       },
                       Quantity = 1,
                       Discount = 0
                    },
                    new SaleItem
                    {
                        Product = new Product {
                            Id = 5,
                            Price = 90,
                            Name = "Webcam HD 1080p",
                            Description = "Webcam com microfone embutido e captura de vídeo em alta definição."
                        },
                        Quantity = 2,
                        Discount = 0
                    },
                     new SaleItem
                    {
                        Product = new Product {
                            Id = 4,
                            Price = 300,
                            Name = "Cadeira Gamer",
                            Description = "Cadeira com ajuste de altura, encosto reclinável e apoio para braços."
                        },
                        Quantity = 2,
                        Discount = 0
                     }
                }
            },

            new Sale()
            {
                Id = Guid.NewGuid(),
                Seller = new Seller {
                    Id = 3,
                    Name = "Carlos Mendes",
                    Email = "carlos.mendes@example.com",
                    PhoneNumber = "(31) 98765-4321"
                },
                Items = new List<SaleItem>()
                {
                    new SaleItem
                    {
                       Product = new Product
                       {
                           Id = 8,
                           Price = 40,
                           Name = "Hub USB 4 Portas",
                           Description = "Hub com 4 entradas USB 3.0 de alta velocidade."
                       },
                       Quantity = 5,
                       Discount = 8
                    },
                    new SaleItem
                    {
                        Product = new Product {
                            Id = 6,
                            Price = 150,
                            Name = "HD Externo 1TB",
                            Description = "Disco rígido portátil USB 3.0 com 1TB de capacidade de armazenamento."
                        },
                        Quantity = 7,
                        Discount = 0
                    },
                    new SaleItem
                    {
                        Product = new Product {
                            Id = 2,
                            Price = 250,
                            Name = "Monitor 24'' Full HD",
                            Description = "Monitor LED com resolução 1920x1080 e taxa de atualização de 75Hz."
                        },
                        Quantity = 2,
                        Discount = 2
                    }
                }
            },
        };

        public async Task<List<Sale>> FindAllSales()
        {
            await Task.Delay(100);
            return _sales;
        }

    }
}
