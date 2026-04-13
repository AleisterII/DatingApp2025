using API.Data;
using API.Entities;
using API.Interfaces;

namespace API.UnitTests.Data;

public class MembersRepositoryTests
{
    private AppDbContext _context;
    private IMembersRepository _membersRepository;
    
    [SetUp]
    public void Setup()
    {
        _context = GlobalTestSetup.AppDbContext;
        _membersRepository = new MembersRepository(_context);
    }
}