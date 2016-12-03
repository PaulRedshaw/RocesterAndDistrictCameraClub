using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Radcc.Mvc
{
    internal class AuthenticationIdentityManager
    {
        public Task<IdentityResult> Roles { get; internal set; }
    }
}