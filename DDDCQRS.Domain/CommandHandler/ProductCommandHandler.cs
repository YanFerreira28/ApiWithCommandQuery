using DDDCQRS.Domain.Command;
using DDDCQRS.Domain.Contracts;
using DDDCQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDCQRS.Domain.CommandHandler
{
    public class ProductCommandHandler :
        IRequestHandler<RegisterProductCommand, bool>,
        IRequestHandler<UpdateProductCommand, bool>,
        IRequestHandler<DeleteProductCommand, bool>
    {
        public readonly IMediator _mediator;
        public readonly IProdutoRepository _repository;

        public ProductCommandHandler(IMediator mediator, IProdutoRepository produtoRepository)
        {
            _mediator = mediator;
            _repository = produtoRepository;
        }

        public Task<bool> Handle(RegisterProductCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(false);
            }

            if(request.IsValid())
            { 
            var obj = new Produto(request.nome, request.fornecedor, request.marca, request.valor);
            _repository.Insert(obj);
            _repository.Save();
            }
            return Task.FromResult(true);


        }

        public Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(false);
            }

            var produto = new Produto(request.id, request.nome, request.fornecedor, request.marca, request.valor);
            _repository.Update(produto);
            _repository.Save();

            if(produto == null)
            {
                throw new Exception("Valor não pode ser nulo");
            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(false);
            }

            _repository.Delete(request.id);

            return Task.FromResult(true);
        }
    }
}
