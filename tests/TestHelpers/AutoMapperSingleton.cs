using AutoMapper;
using IR.Shared.Mapping;

namespace TestHelpers
{
	public static class AutoMapperSingleton
	{
		private static IMapper _mapper;

		public static IMapper Mapper
		{
			get
			{
				if (_mapper != null) return _mapper;
				// Auto Mapper Configurations
				var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });
				var mapper = mappingConfig.CreateMapper();
				_mapper = mapper;

				return _mapper;
			}
		}
	}}