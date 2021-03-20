using Microsoft.Extensions.Logging;
using System;
using System.Threading;

#nullable disable
namespace System
{
    public static class FuncExtensions
    {
        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            T9 operationArg9,
            T10 operationArg10,
            T11 operationArg11,
            T12 operationArg12,
            T13 operationArg13,
            T14 operationArg14,
            T15 operationArg15,
            T16 operationArg16,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10,
                        operationArg11,
                        operationArg12,
                        operationArg13,
                        operationArg14,
                        operationArg15,
                        operationArg16);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         T13 operationArg13,
         T14 operationArg14,
         T15 operationArg15,
         int maxAttempts,
         TimeSpan? delay,
         ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10,
                        operationArg11,
                        operationArg12,
                        operationArg13,
                        operationArg14,
                        operationArg15);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         T13 operationArg13,
         T14 operationArg14,
         int maxAttempts,
         TimeSpan? delay,
         ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10,
                        operationArg11,
                        operationArg12,
                        operationArg13,
                        operationArg14);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         T13 operationArg13,
         int maxAttempts,
         TimeSpan? delay,
         ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10,
                        operationArg11,
                        operationArg12,
                        operationArg13);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         int maxAttempts,
         TimeSpan? delay,
         ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10,
                        operationArg11,
                        operationArg12);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         int maxAttempts,
         TimeSpan? delay,
         ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10,
                        operationArg11);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         int maxAttempts,
         TimeSpan? delay,
         ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9,
                        operationArg10);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }


        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            T9 operationArg9,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, T6, TResult>(
          this Func<T1, T2, T3, T4, T5, T6, TResult> operation,
          T1 operationArg1,
          T2 operationArg2,
          T3 operationArg3,
          T4 operationArg4,
          T5 operationArg5,
          T6 operationArg6,
          int maxAttempts,
          TimeSpan? delay,
          ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(operationArg1, operationArg2, operationArg3, operationArg4, operationArg5);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(operationArg1, operationArg2, operationArg3, operationArg4);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            int maxAttempts,
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(operationArg1, operationArg2, operationArg3);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T1, T2, TResult>(
            this Func<T1, T2, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            int maxAttempts, 
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(operationArg1, operationArg2);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static TResult RetryOnException<TException, T, TResult>(
            this Func<T, TResult> operation,
            T operationArg,
            int maxAttempts, 
            TimeSpan? delay,
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation(operationArg);

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);

                }
            } while (true);
        }

        public static TResult RetryOnException<TException, TResult>(
            this Func<TResult> operation,
            int maxAttempts, 
            TimeSpan? delay, 
            ILogger logger = null) where TException : Exception
        {
            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return operation();

                }
                catch (TException ex)
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        private static void ProcessException<TException>(
            TException ex,
            int attempt, 
            int maxAttempts, 
            TimeSpan? delay, 
            ILogger logger = null) where TException : Exception
        {
            TimeSpan wait = delay ?? TimeSpan.Zero;

            if (attempt == maxAttempts)
                throw ex;

            logger?.LogError(ex, $"Exception caught on attempt {attempt} - will retry after delay {delay}", ex);

            Thread.Sleep(wait);
        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            T9 operationArg9,
            T10 operationArg10,
            T11 operationArg11,
            T12 operationArg12,
            T13 operationArg13,
            T14 operationArg14,
            T15 operationArg15,
            T16 operationArg16,
            ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10,
                    operationArg11,
                    operationArg12,
                    operationArg13,
                    operationArg14,
                    operationArg15,
                    operationArg16);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         T13 operationArg13,
         T14 operationArg14,
         T15 operationArg15,
         ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10,
                    operationArg11,
                    operationArg12,
                    operationArg13,
                    operationArg14,
                    operationArg15);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         T13 operationArg13,
         T14 operationArg14,
         ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10,
                    operationArg11,
                    operationArg12,
                    operationArg13,
                    operationArg14);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         T13 operationArg13,
         ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10,
                    operationArg11,
                    operationArg12,
                    operationArg13);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         T12 operationArg12,
         ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10,
                    operationArg11,
                    operationArg12);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         T11 operationArg11,
         ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10,
                    operationArg11);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
         this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> operation,
         T1 operationArg1,
         T2 operationArg2,
         T3 operationArg3,
         T4 operationArg4,
         T5 operationArg5,
         T6 operationArg6,
         T7 operationArg7,
         T8 operationArg8,
         T9 operationArg9,
         T10 operationArg10,
         ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9,
                    operationArg10);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }


        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            T9 operationArg9,
            ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8,
                    operationArg9);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, TResult>(
          this Func<T1, T2, T3, T4, T5, T6, TResult> operation,
          T1 operationArg1,
          T2 operationArg2,
          T3 operationArg3,
          T4 operationArg4,
          T5 operationArg5,
          T6 operationArg6,
          ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            ILogger logger = null)
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(operationArg1, operationArg2, operationArg3, operationArg4, operationArg5);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(operationArg1, operationArg2, operationArg3, operationArg4);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {


            {
                try
                {

                    return operation(operationArg1, operationArg2, operationArg3);

                }
                catch (TException ex)
                {
                    ProcessException(ex, logger);
                    return default;
                }

            }
        }

        public static TResult IgnoreOnException<TException, T1, T2, TResult>(
            this Func<T1, T2, TResult> operation,
            T1 operationArg1,
            T2 operationArg2,
            ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(operationArg1, operationArg2);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        public static TResult IgnoreOnException<TException, T, TResult>(
            this Func<T, TResult> operation,
            T operationArg,
            ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation(operationArg);

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;

            }

        }

        public static TResult IgnoreOnException<TException, TResult>(
            this Func<TResult> operation,
            ILogger logger = null) 
            where TException : Exception
            where TResult : class
        {
            try
            {

                return operation();

            }
            catch (TException ex)
            {
                ProcessException(ex, logger);
                return default;
            }

        }

        private static void ProcessException<TException>(
            TException ex,
            ILogger logger = null) where TException : Exception
        {
            logger?.LogError(ex, $"Exception of type {ex.GetType()} caught. Ignoring.");
        }
    }
}
#nullable restore