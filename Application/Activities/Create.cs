using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public string Categoria { get; set; }
            public DateTime Data { get; set; }
            public string Cidade { get; set; }
            public string Logradouro { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }
            
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = new Activity
                {
                    Id = request.Id,
                    Titulo = request.Titulo,
                    Categoria = request.Categoria,
                    Data = request.Data,
                    Cidade = request.Cidade,
                    Logradouro = request.Logradouro

                };
                _context.Acitivities.Add(activity);
                var success = await _context.SaveChangesAsync() > 0;

                if(success) return Unit.Value;

                throw new Exception("Problema Saving Changes");
            
            }
        }
    }
}