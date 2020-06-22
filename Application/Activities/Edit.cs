using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistance;

namespace Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public string Categoria { get; set; }
            public DateTime? Data { get; set; }
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
                var activity = await _context.Acitivities.FindAsync(request.Id);
                if (activity == null)
                    throw new Exception("Could not find activity");


                activity.Titulo = request.Titulo ?? activity.Titulo;
                activity.Descricao = request.Descricao ?? activity.Descricao;
                activity.Categoria = request.Categoria ?? activity.Categoria;
                activity.Data = request.Data ?? activity.Data;
                activity.Cidade = request.Cidade ?? activity.Cidade;
                activity.Logradouro = request.Logradouro ?? activity.Logradouro;

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problema Saving Changes");

            }
        }
    }
}