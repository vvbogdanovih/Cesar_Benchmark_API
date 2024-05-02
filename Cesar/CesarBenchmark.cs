using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar_consol
{
    public class CesarBenchmark
    {
        public CesarBenchmark() { }
        // SumBenchmark
        public List<SimpleResult> RunSumBenchmarkCPU(Matrix matrix, int startSize, int endSize, int step)
        {
            CPUBenchmark cPUBenchmark = new CPUBenchmark();
            List<SimpleResult> cPUBenchmarkResult = cPUBenchmark.RunSumTest(matrix, startSize, endSize, step);
            return cPUBenchmarkResult;
        }
        public List<SimpleResult> RunSumBenchmarkCPUMultiThred(Matrix matrix, int startSize, int endSize, int step)
        {
            CPUMultiThredBenchmark cPUMultiThredBenchmark = new CPUMultiThredBenchmark();
            List<SimpleResult> cPUMultiThredBenchmarkResult = cPUMultiThredBenchmark.RunSumTestTestAsync(matrix, startSize, endSize, step);
            return cPUMultiThredBenchmarkResult;
        }
        public List<SimpleResult> RunSumBenchmarkGPU(Matrix matrix, int startSize, int endSize, int step)
        {
            GPUBenchmark gpuBenchmark = new GPUBenchmark();
            List<SimpleResult> gpuBenchmarkResult = gpuBenchmark.RunSumTestGPU(matrix, startSize, endSize, step);
            return gpuBenchmarkResult;
        }
        // MultBenchmark
        public List<SimpleResult> RunMultBenchmarkCPU(Matrix matrixA, Matrix matrixB, int startSize, int endSize, int step)
        {
            CPUBenchmark cPUBenchmark = new CPUBenchmark();
            List<SimpleResult> cPUBenchmarkResult = cPUBenchmark.RunMultTest(matrixA, matrixB, startSize, endSize, step);
            return cPUBenchmarkResult;
        }        
        public List<SimpleResult> RunMultBenchmarkCPUMultiThred(Matrix matrixA, Matrix matrixB, int startSize, int endSize, int step)
        {
            CPUMultiThredBenchmark cPUMultiThredBenchmark = new CPUMultiThredBenchmark();
            List<SimpleResult> cPUMultiThredBenchmarkResult = cPUMultiThredBenchmark.RunMultTestAsync(matrixA, matrixB, startSize, endSize, step);
            return cPUMultiThredBenchmarkResult;
        }        
        public List<SimpleResult> RunMultBenchmarkGPU(Matrix matrixA, Matrix matrixB, int startSize, int endSize, int step)
        {
            GPUBenchmark gpuBenchmark = new GPUBenchmark();
            List<SimpleResult> gpuBenchmarkResult = gpuBenchmark.RunMultTestGPU(matrixA, matrixB, startSize, endSize, step);
            return gpuBenchmarkResult;
        }
        // SingularityBenchmark
        public List<SimpleResult> RunSingularityBenchmarkCPU(Matrix matrix, int startSize, int endSize, int step)
        {
            CPUBenchmark cPUBenchmark = new CPUBenchmark();
            List<SimpleResult> cPUBenchmarkResult = cPUBenchmark.RunSingularityTest(matrix, startSize, endSize, step);
            return cPUBenchmarkResult;
        }
        public List<SimpleResult> RunSingularityBenchmarkCPUMultiThred(Matrix matrix, int startSize, int endSize, int step)
        {
            CPUMultiThredBenchmark cPUMultiThredBenchmark = new CPUMultiThredBenchmark();
            List<SimpleResult> cPUMultiThredBenchmarkResult = cPUMultiThredBenchmark.RunSingularityTestAsync(matrix, startSize, endSize, step);
            return cPUMultiThredBenchmarkResult;
        }
        public List<SimpleResult> RunSingularityBenchmarkGPU(Matrix matrix, int startSize, int endSize, int step)
        {
            GPUBenchmark gpuBenchmark = new GPUBenchmark();
            List<SimpleResult> gpuBenchmarkResult = gpuBenchmark.RunSingularityTestGPU(matrix, startSize, endSize, step);
            return gpuBenchmarkResult;
        }
        /*
        public Result[] RunSumBenchmark(Matrix matrix, int startSize, int endSize, int step)
        {
            CPUBenchmark cPUBenchmark = new CPUBenchmark();
            CPUMultiThredBenchmark cPUMultiThredBenchmark = new CPUMultiThredBenchmark();
            GPUBenchmark gpuBenchmark = new GPUBenchmark();

            List<SimpleResult> cPUBenchmarkResult = cPUBenchmark.RunSumTest(matrix, startSize, endSize, step);
            List<SimpleResult> cPUMultiThredBenchmarkResult = cPUMultiThredBenchmark.RunSumTestTestAsync(matrix, startSize, endSize, step);
            List<SimpleResult> gpuBenchmarkResult = gpuBenchmark.RunSumTestGPU(matrix, startSize, endSize, step);
            Result[] results = new Result[]{
            new Result(cPUBenchmarkResult, "CPU"),
            new Result(cPUMultiThredBenchmarkResult, "CPUMultiThred"),
            new Result(gpuBenchmarkResult, "GPU")};
            return results;
        }

        public Result[] RunMultBenchmark(Matrix matrixA, Matrix matrixB, int startSize, int endSize, int step)
        {
            CPUBenchmark cPUBenchmark = new CPUBenchmark();
            CPUMultiThredBenchmark cPUMultiThredBenchmark = new CPUMultiThredBenchmark();
            GPUBenchmark gpuBenchmark = new GPUBenchmark();

            List<SimpleResult> cPUBenchmarkResult = cPUBenchmark.RunMultTest(matrixA, matrixB, startSize, endSize, step);
            List<SimpleResult> cPUMultiThredBenchmarkResult = cPUMultiThredBenchmark.RunMultTestAsync(matrixA, matrixB, startSize, endSize, step);
            List<SimpleResult> gpuBenchmarkResult = gpuBenchmark.RunMultTestGPU(matrixA, matrixB, startSize, endSize, step);
            Result[] results = new Result[]{
            new Result(cPUBenchmarkResult, "CPU"),
            new Result(cPUMultiThredBenchmarkResult, "CPUMultiThred"),
            new Result(gpuBenchmarkResult, "GPU")};
            return results;
        }

        public Result[] RunSingularityBenchmark(Matrix matrix, int startSize, int endSize, int step)
        {
            CPUBenchmark cPUBenchmark = new CPUBenchmark();
            CPUMultiThredBenchmark cPUMultiThredBenchmark = new CPUMultiThredBenchmark();
            GPUBenchmark gpuBenchmark = new GPUBenchmark();

            List<SimpleResult> cPUBenchmarkResult = cPUBenchmark.RunSingularityTest(matrix, startSize, endSize, step);
            List<SimpleResult> cPUMultiThredBenchmarkResult = cPUMultiThredBenchmark.RunSingularityTestAsync(matrix, startSize, endSize, step);
            List<SimpleResult> gpuBenchmarkResult = gpuBenchmark.RunSingularityTestGPU(matrix, startSize, endSize, step);
            Result[] results = new Result[]{
            new Result(cPUBenchmarkResult, "CPU"),
            new Result(cPUMultiThredBenchmarkResult, "CPUMultiThred"),
            new Result(gpuBenchmarkResult, "GPU")};
            return results;
        }
        */
    }
}
