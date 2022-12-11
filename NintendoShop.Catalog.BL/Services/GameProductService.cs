using AutoMapper;
using NintendoShop.Catalog.BLL.DTOs.GameProduct;
using NintendoShop.Catalog.BLL.Interfaces;
using NintendoShop.Catalog.DAL.Interfaces;
using NintendoShop.Catalog.DAL.Models;

namespace NintendoShop.Catalog.BLL.Services
{
    internal class GameProductService : IGameProductService
    {
        private readonly IGameProductRepository _gameProductRepository;
        private readonly IMapper _mapper;
        public GameProductService(IGameProductRepository gameProductRepository,
            IMapper mapper)
        {
            _gameProductRepository = gameProductRepository;
            _mapper = mapper;
        }

        public async Task<GameProductDto> GetByIdAsync(string id)
        {
            var dbGameProduct = await _gameProductRepository.GetByIdAsync(id);

            return _mapper.Map<GameProductDto>(dbGameProduct);
        }

        public async Task<List<GameProductDto>> GetAllAsync()
        {
            var dbGameProducts = await _gameProductRepository.GetAllAsync();

            return _mapper.Map<List<GameProductDto>>(dbGameProducts);
        }

        public async Task CreateAsync(CreateGameProductDto gameProductDto)
        {
            var gameProductForCreate = _mapper.Map<GameProduct>(gameProductDto);

            await _gameProductRepository.CreateAsync(gameProductForCreate);
        }

        public async Task UpdateAsync(UpdateGameProductDto gameProductDto)
        {
            var gameProductForUpdate = _mapper.Map<GameProduct>(gameProductDto);

            await _gameProductRepository.UpdateAsync(gameProductForUpdate);
        }

        public async Task DeleteAsync(string id)
        {
            await _gameProductRepository.DeleteAsync(id);
        }
    }
}
