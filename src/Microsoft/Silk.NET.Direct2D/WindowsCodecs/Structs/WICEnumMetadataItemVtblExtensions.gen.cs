// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICEnumMetadataItemVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICEnumMetadataItem> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICEnumMetadataItem> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICEnumMetadataItem> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICEnumMetadataItem> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICEnumMetadataItem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICEnumMetadataItem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, uint* pceltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, ref uint pceltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pceltFetchedPtr = &pceltFetched)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValue, pceltFetchedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, ref T0 rgeltValue, uint* pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltValuePtr = &rgeltValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValuePtr, pceltFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, ref T0 rgeltValue, ref uint pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltValuePtr = &rgeltValue)
        {
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValuePtr, pceltFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, ref T0 rgeltId, void* rgeltValue, uint* pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltIdPtr = &rgeltId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValue, pceltFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, ref T0 rgeltId, void* rgeltValue, ref uint pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltIdPtr = &rgeltId)
        {
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValue, pceltFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, ref T0 rgeltId, ref T1 rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltIdPtr = &rgeltId)
        {
            fixed (void* rgeltValuePtr = &rgeltValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValuePtr, pceltFetched);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, ref T0 rgeltId, ref T1 rgeltValue, ref uint pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltIdPtr = &rgeltId)
        {
            fixed (void* rgeltValuePtr = &rgeltValue)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValuePtr, pceltFetchedPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, void* rgeltId, void* rgeltValue, uint* pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValue, pceltFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, void* rgeltId, void* rgeltValue, ref uint pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValue, pceltFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, void* rgeltId, ref T1 rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (void* rgeltValuePtr = &rgeltValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValuePtr, pceltFetched);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, void* rgeltId, ref T1 rgeltValue, ref uint pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (void* rgeltValuePtr = &rgeltValue)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValuePtr, pceltFetchedPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, ref T1 rgeltId, void* rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (void* rgeltIdPtr = &rgeltId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValue, pceltFetched);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, ref T1 rgeltId, void* rgeltValue, ref uint pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (void* rgeltIdPtr = &rgeltId)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValue, pceltFetchedPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1, T2>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, ref T1 rgeltId, ref T2 rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (void* rgeltIdPtr = &rgeltId)
            {
                fixed (void* rgeltValuePtr = &rgeltValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValuePtr, pceltFetched);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Next<T0, T1, T2>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, ref T0 rgeltSchema, ref T1 rgeltId, ref T2 rgeltValue, ref uint pceltFetched) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* rgeltSchemaPtr = &rgeltSchema)
        {
            fixed (void* rgeltIdPtr = &rgeltId)
            {
                fixed (void* rgeltValuePtr = &rgeltValue)
                {
                    fixed (uint* pceltFetchedPtr = &pceltFetched)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, void*, void*, void*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValuePtr, pceltFetchedPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Skip(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, int>)@this->LpVtbl[4])(@this, celt);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IWICEnumMetadataItem> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IWICEnumMetadataItem> thisVtbl, IWICEnumMetadataItem** ppIEnumMetadataItem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, IWICEnumMetadataItem**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadataItem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IWICEnumMetadataItem> thisVtbl, ref IWICEnumMetadataItem* ppIEnumMetadataItem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICEnumMetadataItem** ppIEnumMetadataItemPtr = &ppIEnumMetadataItem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, IWICEnumMetadataItem**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadataItemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICEnumMetadataItem> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICEnumMetadataItem> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, void* rgeltValue, Span<uint> pceltFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, rgeltId, rgeltValue, ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, Span<T0> rgeltValue, uint* pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, rgeltId, ref rgeltValue.GetPinnableReference(), pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, void* rgeltId, Span<T0> rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, rgeltId, ref rgeltValue.GetPinnableReference(), ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, Span<T0> rgeltId, void* rgeltValue, uint* pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, ref rgeltId.GetPinnableReference(), rgeltValue, pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, Span<T0> rgeltId, void* rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, ref rgeltId.GetPinnableReference(), rgeltValue, ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, Span<T0> rgeltId, Span<T1> rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, ref rgeltId.GetPinnableReference(), ref rgeltValue.GetPinnableReference(), pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, void* rgeltSchema, Span<T0> rgeltId, Span<T1> rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgeltSchema, ref rgeltId.GetPinnableReference(), ref rgeltValue.GetPinnableReference(), ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, void* rgeltId, void* rgeltValue, uint* pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), rgeltId, rgeltValue, pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, void* rgeltId, void* rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), rgeltId, rgeltValue, ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, void* rgeltId, Span<T1> rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), rgeltId, ref rgeltValue.GetPinnableReference(), pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, void* rgeltId, Span<T1> rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), rgeltId, ref rgeltValue.GetPinnableReference(), ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, Span<T1> rgeltId, void* rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), ref rgeltId.GetPinnableReference(), rgeltValue, pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, Span<T1> rgeltId, void* rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), ref rgeltId.GetPinnableReference(), rgeltValue, ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<T0, T1, T2>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, Span<T1> rgeltId, Span<T2> rgeltValue, uint* pceltFetched) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), ref rgeltId.GetPinnableReference(), ref rgeltValue.GetPinnableReference(), pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static int Next<T0, T1, T2>(this ComPtr<IWICEnumMetadataItem> thisVtbl, uint celt, Span<T0> rgeltSchema, Span<T1> rgeltId, Span<T2> rgeltValue, Span<uint> pceltFetched) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgeltSchema.GetPinnableReference(), ref rgeltId.GetPinnableReference(), ref rgeltValue.GetPinnableReference(), ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IWICEnumMetadataItem> thisVtbl, ref ComPtr<TI0> ppIEnumMetadataItem) where TI0 : unmanaged, IComVtbl<IWICEnumMetadataItem>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((IWICEnumMetadataItem**) ppIEnumMetadataItem.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICEnumMetadataItem> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}