﻿// ----------------------------------------------------------------------------------Caatag,
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Dns

{
    using System.Management.Automation;

    using ProjectResources = Microsoft.Azure.Commands.Dns.Properties.Resources;

    /// <summary>
    /// Constructs an in-memory dns record object
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DnsRecordConfig"), OutputType(typeof(DnsRecordBase))]
    public class NewAzureRmDnsRecordConfig : DnsBaseCmdlet
    {
        private const string ParameterSetA = "A";
        private const string ParameterSetAaaa = "Aaaa";
        private const string ParameterSetCName = "CName";
        private const string ParameterSetTxt = "Txt";
        private const string ParameterSetSrv = "Srv";
        private const string ParameterSetPtr = "Ptr";
        private const string ParameterSetNaptr = "Naptr";
        private const string ParameterSetNs = "Ns";
        private const string ParameterSetMx = "Mx";
        private const string ParameterSetCaa = "Caa";
        private const string ParameterSetDs = "Ds";
        private const string ParameterSetTlsa = "Tlsa";

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The IPv4 address for the A record to add.", ParameterSetName = ParameterSetA)]
        [ValidateNotNullOrEmpty]
        public string Ipv4Address { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The IPv6 address for the AAAA record to add.", ParameterSetName = ParameterSetAaaa)]
        [ValidateNotNullOrEmpty]
        public string Ipv6Address { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The name server host for the NS record to add. Must not be relative to the name of the zone. Must not have a terminating dot", ParameterSetName = ParameterSetNs)]
        [ValidateNotNullOrEmpty]
        public string Nsdname { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The mail exchange host for the MX record to add. Must not be relative to the name of the zone. Must not have a terminating dot", ParameterSetName = ParameterSetMx)]
        [ValidateNotNullOrEmpty]
        public string Exchange { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The preference value for the MX record to add.", ParameterSetName = ParameterSetMx)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The preference value for the NAPTR record to add.", ParameterSetName = ParameterSetNaptr)]
        [ValidateNotNullOrEmpty]
        public ushort Preference { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The target host for the PTR record to add. Must not be relative to the name of the zone. Must not have a terminating dot", ParameterSetName = ParameterSetPtr)]
        [ValidateNotNullOrEmpty]
        public string Ptrdname { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The text value for the TXT record to add.", ParameterSetName = ParameterSetTxt)]
        [ValidateNotNullOrEmpty]
        public string Value { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The priority value SRV record to add.", ParameterSetName = ParameterSetSrv)]
        [ValidateNotNullOrEmpty]
        public ushort Priority { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The target host for the SRV record to add. Must not be relative to the name of the zone. Must not have a terminating dot", ParameterSetName = ParameterSetSrv)]
        [ValidateNotNullOrEmpty]
        public string Target { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The port number for the SRV record to add.", ParameterSetName = ParameterSetSrv)]
        [ValidateNotNullOrEmpty]
        public ushort Port { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The weight value for the SRV record to add.", ParameterSetName = ParameterSetSrv)]
        [ValidateNotNullOrEmpty]
        public ushort Weight { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The canonical name for the CNAME record to add. Must not be relative to the name of the zone. Must not have a terminating dot", ParameterSetName = ParameterSetCName)]
        [ValidateNotNullOrEmpty]
        public string Cname { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The flags for the CAA record to add. Must be a number between 0 and 255.", ParameterSetName = ParameterSetCaa)]
        [ValidateNotNullOrEmpty]
        public byte CaaFlags { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The tag field of the CAA record to add.", ParameterSetName = ParameterSetCaa)]
        [ValidateNotNullOrEmpty]
        public string CaaTag { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The value field for the CAA record to add.", ParameterSetName = ParameterSetCaa)]
        [ValidateNotNull]
        [AllowEmptyString]
        [ValidateLength(DnsRecordBase.CaaRecordMinLength, DnsRecordBase.CaaRecordMaxLength)]
        public string CaaValue { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The key tag field of the DS record to add.", ParameterSetName = ParameterSetDs)]
        [ValidateNotNullOrEmpty]
        public int KeyTag { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The algorithm field of the DS record to add.", ParameterSetName = ParameterSetDs)]
        [ValidateNotNullOrEmpty]
        public int Algorithm { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The digest type field of the DS record to add.", ParameterSetName = ParameterSetDs)]
        [ValidateNotNullOrEmpty]
        public int DigestType { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The digest field of the DS record to add.", ParameterSetName = ParameterSetDs)]
        [ValidateNotNullOrEmpty]
        public string Digest { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The usage field of the TLSA record to add.", ParameterSetName = ParameterSetTlsa)]
        [ValidateNotNullOrEmpty]
        public int Usage { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The selector field of the TLSA record to add.", ParameterSetName = ParameterSetTlsa)]
        [ValidateNotNullOrEmpty]
        public int Selector { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The matching type field of the TLSA record to add.", ParameterSetName = ParameterSetTlsa)]
        [ValidateNotNullOrEmpty]
        public int MatchingType { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The certificate association data field of the TLSA record to add.", ParameterSetName = ParameterSetTlsa)]
        [ValidateNotNullOrEmpty]
        public string CertificateAssociationData { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The order value for the NAPTR record to add.", ParameterSetName = ParameterSetNaptr)]
        [ValidateNotNullOrEmpty]
        public ushort Order { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The flags value for the NAPTR record to add.", ParameterSetName = ParameterSetNaptr)]
        [ValidateNotNullOrEmpty]
        public string Flags { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The service value for the NAPTR record to add.", ParameterSetName = ParameterSetNaptr)]
        [ValidateNotNullOrEmpty]
        public string Services { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The regular expression value for the NAPTR record to add.", ParameterSetName = ParameterSetNaptr)]
        [ValidateNotNull]
        [AllowEmptyString]
        public string Regexp { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The replacement value for the NAPTR record to add.", ParameterSetName = ParameterSetNaptr)]
        [ValidateNotNullOrEmpty]
        public string Replacement { get; set; }

        public override void ExecuteCmdlet()
        {
            DnsRecordBase result = null;
            switch (this.ParameterSetName)
            {
                case ParameterSetA:
                    {
                        result = new ARecord { Ipv4Address = this.Ipv4Address };
                        break;
                    }

                case ParameterSetAaaa:
                    {
                        result = new AaaaRecord { Ipv6Address = this.Ipv6Address };
                        break;
                    }

                case ParameterSetMx:
                    {
                        result = new MxRecord { Preference = this.Preference, Exchange = this.Exchange };
                        break;
                    }

                case ParameterSetNs:
                    {
                        result = new NsRecord { Nsdname = this.Nsdname };
                        break;
                    }
                case ParameterSetSrv:
                    {
                        result = new SrvRecord { Priority = this.Priority, Port = this.Port, Target = this.Target, Weight = this.Weight };
                        break;
                    }
                case ParameterSetTxt:
                    {
                        result = new TxtRecord { Value = this.Value };
                        break;
                    }
                case ParameterSetCName:
                    {
                        result = new CnameRecord { Cname = this.Cname };
                        break;
                    }
                case ParameterSetPtr:
                    {
                        result = new PtrRecord { Ptrdname = this.Ptrdname };
                        break;
                    }
                case ParameterSetCaa:
                    {
                        result = new CaaRecord { Flags = this.CaaFlags, Tag = this.CaaTag, Value = this.CaaValue };
                        break;
                    }
                case ParameterSetDs:
                    {
                        result = new DsRecord { KeyTag = this.KeyTag, Algorithm = this.Algorithm, DigestType = this.DigestType, Digest = this.Digest };
                        break;
                    }
                case ParameterSetTlsa:
                    {
                        result = new TlsaRecord { Usage = this.Usage, Selector = this.Selector, MatchingType = this.MatchingType, CertificateAssociationData = this.CertificateAssociationData };
                        break;
                    }
                case ParameterSetNaptr:
                    {
                        result = new NaptrRecord { Order = this.Order, Preference = this.Preference, Flags = this.Flags, Services = this.Services, Regexp = this.Regexp, Replacement = this.Replacement };
                        break;
                    }
                default:
                    {
                        throw new PSArgumentException(string.Format(ProjectResources.Error_UnknownParameterSetName, this.ParameterSetName));
                    }
            }

            WriteObject(result);
        }
    }
}
