﻿using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TemplateEngine.Docx.Processors
{
	internal class ProcessContext
	{
		internal WordDocumentContainer Document { get; private set; }
       // internal WordprocessingDocument WordDocument { get; private set; }
        internal Dictionary<int, int> LastNumIds { get; private set; }
/*		internal XDocument MainPart { get; private set; }
		internal XDocument NumberingPart { get; private set; }
		internal XDocument StylesPart { get; private set; }*/

		internal ProcessContext(WordDocumentContainer document)
		{
			Document = document;
            LastNumIds = new Dictionary<int, int>();
			        
		}
	}
}
