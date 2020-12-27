using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RAdminstration.PhoneBooks.Dto;
using RAdminstration.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace RAdminstration.PhoneBooks
{
    public class PersonAppService : RAdminstrationAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        private readonly IMapper _mapper;
        public PersonAppService(IRepository<Person> personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.personEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.personEditDto);
            }
            else
            {
                await CreatePersonAsync(input.personEditDto);
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("该联系人不存在");
            }
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepository.GetAll();
            var personCount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = _mapper.Map<List<PersonListDto>>(persons);
            return new PagedResultDto<PersonListDto>(personCount, dtos);
        }


        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAsync(input.Id.Value);
            return _mapper.Map<PersonListDto>(person);
        }

        protected async Task UpdatePersonAsync(PersonEditDto input) 
        {
            var entity = await _personRepository.GetAsync(input.Id.Value);
            await _personRepository.UpdateAsync(entity);
        }
        protected async Task CreatePersonAsync(PersonEditDto input) 
        {
            await _personRepository.InsertAsync(_mapper.Map<Person>(input));
        }
    }
}
