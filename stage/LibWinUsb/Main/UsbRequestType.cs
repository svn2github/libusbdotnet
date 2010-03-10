// Copyright � 2006-2009 Travis Robinson. All rights reserved.
// 
// website: http://sourceforge.net/projects/libusbdotnet
// e-mail:  libusbdotnet@gmail.com
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
// 
using System;

namespace LibUsbDotNet.Main
{
    ///<summary>For Convienience Endpoint direction, recipient of the request, and request type on one enumeration.</summary>
    [Flags]
    public enum UsbCtrlFlags : byte
    {
        /// <summary>
        /// In Direction
        /// </summary>
        Direction_In = 0x80,
        /// <summary>
        /// Out Direction
        /// </summary>
        Direction_Out = 0x00,

        /// <summary>
        /// Device is recipient.
        /// </summary>
        Recipient_Device = 0x00,
        /// <summary>
        /// Endpoint is recipient.
        /// </summary>
        Recipient_Endpoint = 0x02,
        /// <summary>
        /// Interface is recipient.
        /// </summary>
        Recipient_Interface = 0x01,
        /// <summary>
        /// Other is recipient.
        /// </summary>
        Recipient_Other = 0x03,

        /// <summary>
        /// Class specific request.
        /// </summary>
        RequestType_Class = (0x01 << 5),
        /// <summary>
        /// RESERVED.
        /// </summary>
        RequestType_Reserved = (0x03 << 5),
        /// <summary>
        /// Standard request.
        /// </summary>
        RequestType_Standard = (0x00 << 5),
        /// <summary>
        /// Vendor specific request.
        /// </summary>
        RequestType_Vendor = (0x02 << 5),

    }

    ///<summary>Endpoint direction.</summary>
    /// <seealso cref="UsbCtrlFlags"/>
    [Flags]
    public enum UsbEndpointDirection : byte
    {
        /// <summary>
        /// In Direction
        /// </summary>
        EndpointIn = 0x80,
        /// <summary>
        /// Out Direction
        /// </summary>
        EndpointOut = 0x00,
    }

    ///<summary>Recipient of the request.</summary>
    /// <seealso cref="UsbCtrlFlags"/>
    [Flags]
    public enum UsbRequestRecipient : byte
    {
        /// <summary>
        /// Device is recipient.
        /// </summary>
        RecipDevice = 0x00,
        /// <summary>
        /// Endpoint is recipient.
        /// </summary>
        RecipEndpoint = 0x02,
        /// <summary>
        /// Interface is recipient.
        /// </summary>
        RecipInterface = 0x01,
        /// <summary>
        /// Other is recipient.
        /// </summary>
        RecipOther = 0x03,
    }

    /// <summary>
    /// Standard USB requests.
    /// </summary>
    /// <seealso cref="UsbCtrlFlags"/>
    [Flags]
    public enum UsbRequestType : byte
    {
        /// <summary>
        /// Class specific request.
        /// </summary>
        TypeClass = (0x01 << 5),
        /// <summary>
        /// RESERVED.
        /// </summary>
        TypeReserved = (0x03 << 5),
        /// <summary>
        /// Standard request.
        /// </summary>
        TypeStandard = (0x00 << 5),
        /// <summary>
        /// Vendor specific request.
        /// </summary>
        TypeVendor = (0x02 << 5),
    }
}