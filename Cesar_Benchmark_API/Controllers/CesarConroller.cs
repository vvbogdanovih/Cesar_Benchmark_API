﻿using BLL.Models;
using Cesar_consol;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Claims;


namespace Cesar_Benchmark_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CesarConroller : Controller
    {
        CesarBenchmark benchmark = new CesarBenchmark();
        // Sum
        [HttpPost]
        [Route("SumCPU")]
        public async Task<ActionResult<List<SimpleResult>>> SumCPU([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> SumCPUResult = benchmark.RunSumBenchmarkCPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(SumCPUResult);
        }

        [HttpPost]
        [Route("SumCPUMultiThred")]
        public async Task<ActionResult<List<SimpleResult>>> SumCPUMultiThred([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> SumCPUMultiThredResult = benchmark.RunSumBenchmarkCPUMultiThred(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(SumCPUMultiThredResult);
        }

        [HttpPost]
        [Route("SumGPU")]
        public async Task<ActionResult<List<SimpleResult>>> SumGPU([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> SumGPUResult = benchmark.RunSumBenchmarkGPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(SumGPUResult);
        }
        // Mult
        [HttpPost]
        [Route("MultCPU")]
        public async Task<ActionResult<List<SimpleResult>>> MultCPU([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> MultCPUResult = benchmark.RunMultBenchmarkCPU(new Matrix(brm.Data), new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(MultCPUResult);
        }

        [HttpPost]
        [Route("MultCPUMultiThred")]
        public async Task<ActionResult<List<SimpleResult>>> MultCPUMultiThred([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> MultCPUMultiThredResult = benchmark.RunMultBenchmarkCPUMultiThred(new Matrix(brm.Data), new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(MultCPUMultiThredResult);
        }

        [HttpPost]
        [Route("MultGPU")]
        public async Task<ActionResult<List<SimpleResult>>> MultGPU([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> MultGPUResult = benchmark.RunMultBenchmarkGPU(new Matrix(brm.Data), new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(MultGPUResult);
        }
        // Singularity
        [HttpPost]
        [Route("SingCPU")]
        public async Task<ActionResult<List<SimpleResult>>> SingCPU([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> SingCPUResult = benchmark.RunSingularityBenchmarkCPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(SingCPUResult);
        }

        [HttpPost]
        [Route("SingCPUMultiThred")]
        public async Task<ActionResult<List<SimpleResult>>> SingCPUMultiThred([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> SingCPUMultiThredResult = benchmark.RunSingularityBenchmarkCPUMultiThred(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(SingCPUMultiThredResult);
        }

        [HttpPost]
        [Route("SingGPU")]
        public async Task<ActionResult<List<SimpleResult>>> SingGPU([FromBody] BenchmarkRequestModel brm)
        {
            List<SimpleResult> SingGPUResult = benchmark.RunSingularityBenchmarkGPU(new Matrix(brm.Data), brm.StartSize, brm.EndSize, brm.Step);
            return Ok(SingGPUResult);
        }
    }
}
