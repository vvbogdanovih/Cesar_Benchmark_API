using BLL.Models;
using Cesar_consol;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Claims;


namespace Cesar_Benchmark_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CesarConroller : Controller
    {
        private readonly ILogger<CesarConroller> _logger;

        public CesarConroller(ILogger<CesarConroller> logger)
        {
            _logger = logger;
        }
        CesarBenchmark benchmark = new CesarBenchmark();
        // Sum
        [HttpPost]
        [Route("SumCPU")]
        public async Task<ActionResult<List<SimpleResult>>> SumCPU([FromBody] BenchmarkRequestModel brm)
        {            
            _logger.LogInformation("SumCPU at: " + DateTime.Now+ "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> SumCPUResult = benchmark.RunSumBenchmarkCPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(SumCPUResult);
        }

        [HttpPost]
        [Route("SumCPUMultiThred")]
        public async Task<ActionResult<List<SimpleResult>>> SumCPUMultiThred([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("SumCPUMultiThred at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> SumCPUMultiThredResult = benchmark.RunSumBenchmarkCPUMultiThred(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now); 
            return Ok(SumCPUMultiThredResult);
        }

        [HttpPost]
        [Route("SumGPU")]
        public async Task<ActionResult<List<SimpleResult>>> SumGPU([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("SumGPU at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> SumGPUResult = benchmark.RunSumBenchmarkGPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(SumGPUResult);
        }
        // Mult
        [HttpPost]
        [Route("MultCPU")]
        public async Task<ActionResult<List<SimpleResult>>> MultCPU([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("MultCPU at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> MultCPUResult = benchmark.RunMultBenchmarkCPU(new Matrix(brm.Data), new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(MultCPUResult);
        }

        [HttpPost]
        [Route("MultCPUMultiThred")]
        public async Task<ActionResult<List<SimpleResult>>> MultCPUMultiThred([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("MultCPUMultiThred at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> MultCPUMultiThredResult = benchmark.RunMultBenchmarkCPUMultiThred(new Matrix(brm.Data), new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(MultCPUMultiThredResult);
        }

        [HttpPost]
        [Route("MultGPU")]
        public async Task<ActionResult<List<SimpleResult>>> MultGPU([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("MultGPU at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> MultGPUResult = benchmark.RunMultBenchmarkGPU(new Matrix(brm.Data), new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(MultGPUResult);
        }
        // Singularity
        [HttpPost]
        [Route("SingCPU")]
        public async Task<ActionResult<List<SimpleResult>>> SingCPU([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("SingCPU at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> SingCPUResult = benchmark.RunSingularityBenchmarkCPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(SingCPUResult);
        }

        [HttpPost]
        [Route("SingCPUMultiThred")]
        public async Task<ActionResult<List<SimpleResult>>> SingCPUMultiThred([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("SingCPUMultiThred at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> SingCPUMultiThredResult = benchmark.RunSingularityBenchmarkCPUMultiThred(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(SingCPUMultiThredResult);
        }

        [HttpPost]
        [Route("SingGPU")]
        public async Task<ActionResult<List<SimpleResult>>> SingGPU([FromBody] BenchmarkRequestModel brm)
        {
            _logger.LogInformation("SingGPU at: " + DateTime.Now + "\nStartSize: " + brm.StartSize + "; EndSize: " + brm.EndSize + "; Step: " + brm.Step);
            List<SimpleResult> SingGPUResult = benchmark.RunSingularityBenchmarkGPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            _logger.LogInformation("Comlpitet at: " + DateTime.Now);
            return Ok(SingGPUResult);
        }
    }
}
