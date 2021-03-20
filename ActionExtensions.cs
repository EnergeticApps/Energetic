using Microsoft.Extensions.Logging;
using System;
using System.Threading;

#nullable disable
namespace System
{
    public static class ActionExtensions
    {
        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }


        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> operation,
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
                    operation(
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
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }


        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> operation,
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
                    operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8,
                        operationArg9);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> operation,
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
                    operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7,
                        operationArg8);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> operation,
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
                    operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6,
                        operationArg7);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5, T6>(
          this Action<T1, T2, T3, T4, T5, T6> operation,
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
                    operation(
                        operationArg1,
                        operationArg2,
                        operationArg3,
                        operationArg4,
                        operationArg5,
                        operationArg6);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> operation,
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
                    operation(operationArg1, operationArg2, operationArg3, operationArg4, operationArg5);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> operation,
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
                    operation(operationArg1, operationArg2, operationArg3, operationArg4);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2, T3>(
            this Action<T1, T2, T3> operation,
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
                    operation(operationArg1, operationArg2, operationArg3);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T1, T2>(
            this Action<T1, T2> operation,
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
                    operation(operationArg1, operationArg2);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);
                }
            } while (true);
        }

        public static void RetryOnException<TException, T>(
            this Action<T> operation,
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
                    operation(operationArg);
                    break;
                }
                catch (TException ex) when (!(logger is null))
                {
                    ProcessException(ex, attempts, maxAttempts, delay, logger);

                }
            } while (true);
        }

        public static void RetryOnException<TException>(
            this Action operation,
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
                    operation();
                    break;
                }
                catch (TException ex) when (!(logger is null))
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

            logger.LogError(ex, $"Exception caught on attempt {attempt} - will retry after delay {delay}", ex);

            Thread.Sleep(wait);
        }


        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> operation,
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
        ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }
        }


        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> operation,
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
         ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> operation,
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
         ILogger logger = null) where TException : Exception
        {
            try
            {
                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> operation,
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
         ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> operation,
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
         ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }
        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> operation,
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
         ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
         this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> operation,
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
         ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }


        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            T9 operationArg9,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
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
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            T8 operationArg8,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7,
                    operationArg8);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            T6 operationArg6,
            T7 operationArg7,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6,
                    operationArg7);

            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5, T6>(
          this Action<T1, T2, T3, T4, T5, T6> operation,
          T1 operationArg1,
          T2 operationArg2,
          T3 operationArg3,
          T4 operationArg4,
          T5 operationArg5,
          T6 operationArg6,
          ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(
                    operationArg1,
                    operationArg2,
                    operationArg3,
                    operationArg4,
                    operationArg5,
                    operationArg6);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            T5 operationArg5,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(operationArg1, operationArg2, operationArg3, operationArg4, operationArg5);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            T4 operationArg4,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(operationArg1, operationArg2, operationArg3, operationArg4);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2, T3>(
            this Action<T1, T2, T3> operation,
            T1 operationArg1,
            T2 operationArg2,
            T3 operationArg3,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(operationArg1, operationArg2, operationArg3);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T1, T2>(
            this Action<T1, T2> operation,
            T1 operationArg1,
            T2 operationArg2,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(operationArg1, operationArg2);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;
            }

        }

        public static void IgnoreOnException<TException, T>(
            this Action<T> operation,
            T operationArg,


            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation(operationArg);
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"An exception of type {ex.GetType()} was thrown. Ignoring."); return;

            }

        }

        public static void IgnoreOnException<TException>(
            this Action operation,
            ILogger logger = null) where TException : Exception
        {
            try
            {

                operation();
            }
            catch (TException ex) when (!(logger is null))
            {
                logger.LogError(ex, $"Exception of type {ex.GetType()} caught. Ignoring.");
            }

        }
    }
}
#nullable restore