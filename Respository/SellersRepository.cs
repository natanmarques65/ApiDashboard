using ApiDashboard.Model;

namespace ApiDashboard.Respository
{
    public static class SellersRepository
    {
        private static readonly List<Seller> _sellers = new List<Seller>()
        {
            new Seller {
                Id = 1,
                Name = "Ana Souza",
                Email = "ana.souza@example.com",
                PhoneNumber = "(11) 91234-5678"
            },
            new Seller {
                Id = 2,
                Name = "Bruno Lima",
                Email = "bruno.lima@example.com",
                PhoneNumber = "(21) 99876-5432"
            },
            new Seller {
                Id = 3,
                Name = "Carlos Mendes",
                Email = "carlos.mendes@example.com",
                PhoneNumber = "(31) 98765-4321"
            },
            new Seller {
                Id = 4,
                Name = "Daniela Rocha",
                Email = "daniela.rocha@example.com",
                PhoneNumber = "(41) 97654-3210"
            },
            new Seller {
                Id = 5,
                Name = "Eduardo Ramos",
                Email = "eduardo.ramos@example.com",
                PhoneNumber = "(51) 96543-2109"
            },
            new Seller {
                Id = 6,
                Name = "Fernanda Alves",
                Email = "fernanda.alves@example.com",
                PhoneNumber = "(61) 95432-1098"
            },
            new Seller {
                Id = 7,
                Name = "Gabriel Martins",
                Email = "gabriel.martins@example.com",
                PhoneNumber = "(71) 94321-0987"
            },
            new Seller {
                Id = 8,
                Name = "Helena Costa",
                Email = "helena.costa@example.com",
                PhoneNumber = "(81) 93210-9876"
            },
            new Seller {
                Id = 9,
                Name = "Igor Fernandes",
                Email = "igor.fernandes@example.com",
                PhoneNumber = "(91) 92109-8765"
            },
            new Seller {
                Id = 10,
                Name = "Juliana Pinto",
                Email = "juliana.pinto@example.com",
                PhoneNumber = "(85) 91098-7654"
            }
        };

        public async static Task<List<Seller>> FindAllSellers()
        {
            await Task.Delay(100);
            return _sellers;
        }
    };

}
