﻿using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("D5F88961-BD99-465A-A158-85CE9F7B07AC")]
	//NOTE: Это хотели, чтобы можно было использовать XML-сериализацию для классов
	[XmlType(TypeName = "UniversalTransferDocumentStatus", Namespace = "https://diadoc-api.kontur.ru")]
	public enum UniversalTransferDocumentStatus
	{
		UnknownDocumentStatus = 0,
		OutboundWaitingForSenderSignature = 1,
		OutboundWaitingForInvoiceReceiptAndRecipientSignature = 2,
		OutboundWaitingForInvoiceReceipt = 3,
		OutboundWaitingForRecipientSignature = 4,
		OutboundWithRecipientSignature = 5,
		OutboundRecipientSignatureRequestRejected = 6,
		OutboundInvalidSenderSignature = 7,
		OutboundNotFinished = 8,
		OutboundFinished = 9,
		InboundWaitingForRecipientSignature = 16,
		InboundWithRecipientSignature = 17,
		InboundRecipientSignatureRequestRejected = 18,
		InboundInvalidRecipientSignature = 19,
		InboundNotFinished = 20,
		InboundFinished = 21
	}
}