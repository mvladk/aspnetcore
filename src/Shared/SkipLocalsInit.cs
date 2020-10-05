// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Used to indicate to the compiler that the .locals init flag should not be set in method headers.
#if NET6_0
[module: System.Runtime.CompilerServices.SkipLocalsInit]
#else
#error Target frameworks need to be updated.
#endif
