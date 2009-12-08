/* Copyright (c) 2006 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/
#region Using directives

#define USE_TRACING

using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;

#endregion


/////////////////////////////////////////////////////////////////////
// <summary>contains support classes to work with 
// the resumable upload protocol. 
//  </summary>
////////////////////////////////////////////////////////////////////
namespace Google.GData.Client.ResumableUpload
{

    class ResumableUploader
    {
        // chunksize in Megabytes
        private int chunkSize;

        /// <summary>
        /// Default constructor. Uses the default chunksize of one megabyte
        /// </summary>
        /// <returns></returns>
        public ResumableUploader() : this(1)
        {
        }

        /// <summary>
        /// ResumableUploader constructor. 
        /// </summary>
        /// <param name="chunkSize">the upload chunksize in Megabytes</param>
        /// <returns></returns>
        public ResumableUploader(int chunkSize)
        {
        }

        /// <summary>
        /// Uploads an entry, including it's media to the uri given.
        /// </summary>
        /// <param name="resumableUploadUri"></param>
        /// <param name="settings"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public WebResponse Upload(Uri resumableUploadUri, RequestSettings settings, AbstractEntry payload)
        {
            return null;
        }
        
    }
}