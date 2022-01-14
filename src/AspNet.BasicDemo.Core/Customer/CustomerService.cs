namespace AspNet.BasicDemo.Core.Customer;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ILogger _logger;
    private readonly IMapper _mapper;

    public CustomerService(ICustomerRepository customerRepository, IMapper mapper, ILogger<CustomerService> logger)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers()
    {
        _logger.LogInformation("Getting all customers");
        var customers = await _customerRepository.GetAll();
        var customerViewModels = _mapper.Map<List<CustomerViewModel>>(customers);
        _logger.LogInformation($"{customers.Count} customers found");
        return customerViewModels;
    }

    public async Task<CustomerViewModel> GetCustomerById(Guid id)
    {
        _logger.LogInformation($"Getting customer with id {id}");
        var customer = await _customerRepository.Get(id);
        var customerViewModel = _mapper.Map<CustomerViewModel>(customer);
        return customerViewModel;
    }

    public async Task<CustomerViewModel> CreateCustomer(CreateCustomerCommand createCustomerCommand)
    {
        _logger.LogInformation($"Creating customer {createCustomerCommand.Name}");
        var customer = _mapper.Map<Entities.Customer>(createCustomerCommand);
        _customerRepository.Add(customer);
        await _customerRepository.SaveChangesAsync();
        var customerViewModel = _mapper.Map<CustomerViewModel>(customer);
        return customerViewModel;
    }

    public async Task<CustomerViewModel> UpdateCustomer(UpdateCustomerInfoCommand updateCustomerInfoCommand)
    {
        var customer = await _customerRepository.Get(updateCustomerInfoCommand.CustomerId);
        if (customer is not null)
        {
            _mapper.Map(updateCustomerInfoCommand, customer);
            await _customerRepository.SaveChangesAsync();
            var customerViewModel = _mapper.Map<CustomerViewModel>(customer);
            return customerViewModel;
        }

        return null;
    }

    public async Task<bool> DeleteCustomer(Guid customerId)
    {
        var exists = await _customerRepository.Remove(customerId);
        if (exists)
            await _customerRepository.SaveChangesAsync();
        return exists;
    }
}