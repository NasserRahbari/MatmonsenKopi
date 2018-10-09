
with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Transponder', 'Transponder: fra engelsk transmitter ''sender'' og respond ''svare''. Trådløs innretning som når den mottar et visst signal, automatisk sender ut et eget signal. Brukes ved navigering via satellitt.', 155897, '2018-06-22T15:32:04Z', '2018-08-17T14:22:14Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Transponder', 'Transponder: fra engelsk transmitter ''sender'' og respond ''svare''. Trådløs innretning som når den mottar et visst signal, automatisk sender ut et eget signal, brukes ved navigering via satellitt.', 155897, '2018-06-22T15:32:04Z', '2018-08-17T14:22:14Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Trykkavlasting ', 'Produksjon ved hjelp av trykkavlasting vil si at trykket i reservoaret er drivkraften til produksjonen. Etterhvert som reservoaret tømmes, vil trykket falle og trykket ved brønnhodet synker. I senfasen vil produksjonen kreve trykkstøtte fra f.eks. injeksjon i feltet eller med pumper i brønnen.', 150238, '2018-06-22T15:42:11Z', '2018-09-04T08:43:56Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Trykkavlasting ', 'Produksjon ved hjelp av trykkavlasting vil si at trykket i reservoaret er drivkraften til produksjonen. Ettehvert som reservoaret tømmes, vil trykket falle og trykket ved brønnhodet synker. I senfasen vi produksjonen kreve trykkstøtte fra f.eks. injeksjon i feltet eller med pumper i brønnen.', 150238, '2018-06-22T15:42:11Z', '2018-09-04T08:43:56Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '21.09.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Emulsjonsbryter', 'En emulsjonsbryter er et stoff som kan hjelpe emulgerte stoffer å separeres fra hverandre. En emulsjon er en miks av to eller flere væsker som ikke kan blandes på vanlig måte. En normal blanding er for eksempel vann og saft, som begge er vannbaserte og blandes fullstendig sammen. Olje og vann derimot vil bestå av dråpefase i væskefase, enten som vanndråper i olje eller som oljedråper i vann.', 149947, '2018-06-22T15:35:58Z', '2018-09-04T08:43:44Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '21.09.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Emulsjonsbryter', 'En emulsjonsbryter er et stoff som kan hjelpe emulgerte stoffer å separeres fra hverandre. En emulsjon er en miks av to eller flere væsker som ikke kan blandes på vanlig måte. En normal blanding er for eksempel vann og saft, som begge er vannbaserte og blandes fullstendig sammen. Olje og vann derimot vil bestå av dråpefase i væskefase, enten som vanndråper i olje eller som oljedråper i vann.', 149947, '2018-06-22T15:35:58Z', '2018-09-04T08:43:44Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '02.11.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Agitere', 'Agitere: å bevege, røre, uroe. Beskriver omrøring i større væskevolum som f.eks. i industrielle tankstørrelser. Agitator er en motordrevet visp.', 151862, '2018-06-22T15:36:21Z', '2018-09-04T08:43:49Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '02.11.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Agitere', 'Agitere: å bevege, røre, uroe. Beskriver omrøring i større væskevolum som f.eks. i industrielle tankstørrelser. Agitator er en motordrevet visp.', 151862, '2018-06-22T15:36:21Z', '2018-09-04T08:43:49Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '28.11.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Nærbrønnområdet ', 'Nærbrønnområdet er den delen av formasjonen/bergarten som grenser til brønnen som bores.', 153313, '2018-06-22T15:35:22Z', '2018-09-04T08:43:40Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '28.11.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Nærbrønnområdet ', 'Nærbrønnområdet er den delen av formasjonen/bergarten som grenser til brønnen som bores.', 153313, '2018-06-22T15:35:22Z', '2018-09-04T08:43:40Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '08.12.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Gjennombrudd', 'Gass- og vann-gjennombrudd beskriver situasjonen som oppstår når oljeproduksjonen går over til en ny fase med vann eller gass som følger oljen opp til overflaten. Vanngjennombrudd er et problem fordi vannet er forurenset og må behandles før det kan dumpes. Gassgjennombrudd er et problem fordi trykket i reservoaret faller dramatisk når gassen strømmer fritt ut i brønnen, noe som gjør at oljereserven blir liggende igjen i oljefellen.', 154126, '2018-06-22T15:38:46Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '08.12.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Gjennombrudd', 'Gass- og vann-gjennombrudd beskriver situasjonen som oppstår når oljeproduksjonen går over til en ny fase med vann eller gass som følger oljen opp til overflaten. Vanngjennombrudd er et problem fordi vannet er forurenset og må behandles før det kan dumpes. Gassgjennombrudd er et problem fordi trykket i reservoaret faller dramatisk når gassen strømmer fritt ut i brønnen, noe som gjør at oljereserven blir liggende igjen i oljefellen.', 154126, '2018-06-22T15:38:46Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '03.12.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kokepunktstrykk', 'Kokepunktstrykk (bubble point pressure) er trykket ved en gitt temperatur som gjør at væsken (oljen) slipper ut gass fra væskeformen. Gass kan frigjøres ved at trykk/temperatur økes (vann til vanndamp) eller reduseres (uttak av olje fra reservoar). Et eksempel på norsk sokkel: ... kokepunktet for oljen målt til 6 bar under reservoartrykket ved reservoartemperatur. Reservoartrykket var 408 bar.', 153769, '2018-06-22T15:38:40Z', '2018-09-04T08:43:32Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '03.12.2015', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kokepunktstrykk', 'Kokepunktstrykk (bubble point pressure) er trykket ved en gitt temperatur som gjør at væsken (oljen) slipper ut gass fra væskeformen. Gass kan frigjøres ved at trykk/temperatur økes (vann til vanndamp) eller reduseres (uttak av olje fra reservoar). Et eksempel på norsk sokkel: ... kokepunktet for oljen målt til 6 bar under reservoartrykket ved reservoartemperatur. Reservoartrykket var 408 bar.', 153769, '2018-06-22T15:38:40Z', '2018-09-04T08:43:32Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '23.03.2016', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('API', 'API - American Petroleum Institute. API er mest kjent for arbeidet med utforming og regulering av standarder til den amerikanske olje- og gassindustrien, på samme måte som NORSOK fungerer for norsk sokkel. API standard er internasjonalt akseptert og refereres til blant annet i norske standarder. API tilbyr også godkjenning (sertifisering) og opplæring.', 160648, '2018-06-22T15:33:49Z', '2018-09-04T08:43:51Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '23.03.2016', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('API', 'API - American Petroleum Institute. API er mest kjent for arbeidet med utforming og regulering av standarder til den amerikanske olje- og gassindustrien, på samme måte som NORSOK fungerer for norsk sokkel. API standard er internasjonalt akseptert og refereres til blant annet i norske standarder. API tilbyr også godkjenning (sertifisering) og opplæring.', 160648, '2018-06-22T15:33:49Z', '2018-09-04T08:43:51Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Hiv', 'Fra engelsk heave. Hiv er den vertikale bevegelsen som skapes av bølger mot et flytende objekt. Størrelsen på hiv oppgis som avstand fra bølgetopp til bølgedal.', 155890, '2018-06-22T15:32:09Z', '2018-08-17T14:22:08Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '11.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Hiv', 'Fra engelsk heave. Hiv er den vertikale bevegelsen som skapes av bølger på et flytende objekt. Størrelsen på hiv oppgis som avstand fra bølgetopp til bølgedal.', 155890, '2018-06-22T15:32:09Z', '2018-08-17T14:22:08Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '01.09.2017', '01.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('NAS (nødavstengning)', 'Nødavstenging av brønner deles i to nivå: NAS 2 stenger brønnene ved DHSV. NAS 1 stenger hovedgenerator og starter nødstrøm. I tillegg isoleres alt som kan bidra til eksplosjon. Nødavstenging initieres automatisk ved feil i kritiske komponenter og kan også utløses ved manuell trykknapp.', 181907, '2018-06-22T15:41:42Z', '2018-09-04T08:43:39Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '01.09.2017', '01.09.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('NAS (nødavstengning)', 'Nødavstenging av brønner deles i to nivå: NAS 2 stenger brønnene ved DHSV. NAS 1 stenger hovedgenerator og starter nødstrøm. I tillegg isoleres alt som kan bidra til eksplosjon. Nødavstenging initieres automatisk ved feil i kritiske komponenter og kan også utløses ved manuell trykknapp.', 181907, '2018-06-22T15:41:42Z', '2018-09-04T08:43:39Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '28.11.2015', '28.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Permeabilitet ', 'Permeabiliteten til et porøst materiale (f.eks. reservoarbergart) er et mål for gjennomstrømmeligheten i materialet. Det vil si evnen til å transportere væske eller gass fra et område til et annet område i materialet. Det er kanaler som forbinder porene i materialet. Permeabilitet måles i darcy.', 153312, '2018-06-22T15:35:22Z', '2018-09-04T08:44:13Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '28.11.2015', '28.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Permeabilitet ', 'Permeabiliteten til et porøst materiale (f.eks. reservoarbergart) er et mål for gjennomstrømmeligheten i materialet. Det vil si evnen til å transportere væske eller gass fra et område til et annet område i materialet. Det er kanaler som forbinder porene i materialet. Permeabilitet måles i darcy.', 153312, '2018-06-22T15:35:22Z', '2018-09-04T08:44:13Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '25.08.2017', '25.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pinned', 'Pinned er engelsk og betyr at det er skrudd inn skruer som er sentrale for virkemåten. Noen skruer skal holde to deler sammen, andre skruer skal kunne deles i to med skyv- eller drakraft.', 181780, '2018-06-22T15:41:13Z', '2018-09-04T08:43:42Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '25.08.2017', '25.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pinned', 'Pinned er engelsk og betyr at det er skrudd inn skruer som er sentrale for virkemåten. Noen skruer skal holde to deler sammen, andre skruer skal kunne deles i to med skyv- eller drakraft.', 181780, '2018-06-22T15:41:13Z', '2018-09-04T08:43:42Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fagkomité', 'Nesten alle saker som tas opp på Stortinget, behandles først i en fagkomité. Fagkomiteene har ulike arbeidsområder. Alle stortingsrepresentantene sitter i en fagkomité.', 11270, '2018-06-22T15:02:29Z', '2018-08-20T10:16:46Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fagkomité', 'Nesten alle saker som skal takast opp på Stortinget, blir først handsama i ein fagkomité. Fagkomiteane har ulike arbeidsområde. Alle stortingsrepresentantane sit i ein fagkomité.', 11270, '2018-06-22T15:02:29Z', '2018-08-20T10:16:46Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Spørretime', 'Spørretime er et møte på Stortinget der stortingsrepresentantene kan stille spørsmål til statsrådene. Spørretimen holdes normalt hver onsdag. I den muntlige spørretimen svarer statsrådene spontant på spørsmål de ikke har fått høre på forhånd. Vanligvis møter to til tre statsråder til den muntlige spørretimen. I den ordinære spørretimen besvares spørsmål som er blitt innlevert av representantene senest fredagen uken før, og som statsrådene dermed har forberedt seg på.', 11284, '2018-06-22T15:02:27Z', '2018-08-20T10:16:45Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Spørjetime', 'Spørjetime er eit møte på Stortinget der stortingsrepresentantane kan stille spørsmål til statsrådane. Spørjetimen blir normalt halden kvar onsdag. I den munnlege spørjetimen svarer statsrådane spontant på spørsmål dei ikkje har fått høyre på førehand. Til vanleg møter to til tre statsrådar til den munnlege spørjetimen. I den ordinære spørjetimen svarer statsrådane på spørsmål som er blitt leverte inn av representantane seinast fredagen veka før, og som statsrådane dermed har førebudd seg på.', 11284, '2018-06-22T15:02:27Z', '2018-08-20T10:16:45Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '23.02.2010', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Stortingssesjon', 'En stortingssesjon er den tida stortinget sitter sammen, eller er samlet. Stortingssesjonen starter som regel i oktober og avsluttes i slutten av juni. Stortinget er altså ikke samlet på sommeren.', 51216, '2018-06-22T15:02:28Z', '2018-08-20T10:16:45Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '23.02.2010', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Stortingssesjon', 'Ein stortingssesjon er den tida stortinget sit saman, eller er samla. Stortingssesjonen startar som regel i oktober og blir avslutta i slutten av juni. Stortinget er altså ikkje samla på sommaren.', 51216, '2018-06-22T15:02:28Z', '2018-08-20T10:16:45Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Forskrift', 'En forskrift er en detaljbestemmelse til en lov vedtatt av Stortinget. Når Stortinget vedtar loven, overlates det ofte til regjeringen å utarbeide de utfyllende detaljene. Slike detaljbestemmelser kan endres uten at loven må opp til ny behandling i Stortinget.', 11273, '2018-06-22T15:02:31Z', '2018-08-20T10:16:47Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Forskrift', 'Ei forskrift er ei detaljert presisering til ei lov vedteken av Stortinget. Når Stortinget vedtek lova, blir det ofte overlate til regjeringa å utarbeide dei utfyllande detaljane. Forskriftene kan endrast utan at lova må opp til ny handsaming i Stortinget.', 11273, '2018-06-22T15:02:31Z', '2018-08-20T10:16:47Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Statsbudsjett', 'Statsbudsjettet er et budsjett over statens inntekter og utgifter. Det vedtas i Stortinget i slutten av hver høstsesjon. Forslaget til statsbudsjett fremmes av regjeringen og får alltid "Proposisjon til Stortinget nr. 1" (Prop. 1 S.) i navnet sitt.', 11286, '2018-06-22T15:02:27Z', '2018-08-20T10:16:44Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Statsbudsjett', 'Statsbudsjettet er eit budsjett over inntektene og utgiftene til staten. Det blir vedteke i Stortinget i slutten av kvar haustsesjon. Forslaget til statsbudsjett blir fremja av regjeringa og får alltid "Proposisjon til Stortinget nr. 1" (Prop. 1 S.) i namnet sitt.', 11286, '2018-06-22T15:02:27Z', '2018-08-20T10:16:44Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fullmaktslov', 'Fullmaktslov er en lov der Stortinget overlater (delegerer) til regjeringen og forvaltningen å utforme nærmere detaljerte regler og forskrifter innenfor lovens område.', 11267, '2018-06-22T15:02:31Z', '2018-08-20T10:16:48Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fullmaktslov', 'Fullmaktslov er ei lov som Stortinget overlèt (delegerer) til regjeringa og forvaltinga å utforme nærmare detaljerte reglar og forskrifter til innanfor området for lova.', 11267, '2018-06-22T15:02:31Z', '2018-08-20T10:16:48Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Partigruppe', 'Ei partigruppe er en gruppe bestående av alle representantene fra samme politiske parti på Stortinget. Alle stortingsrepresentantene tilhører en partigruppe i Stortinget.', 11280, '2018-06-22T15:02:30Z', '2018-08-20T10:16:47Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '24.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Partigruppe', 'Ei partigruppe er ei gruppe sett saman av alle representantane frå same politiske parti på Stortinget. Alle stortingsrepresentantane høyrer til i ei partigruppe i Stortinget.', 11280, '2018-06-22T15:02:30Z', '2018-08-20T10:16:47Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('rettsstat', 'En rettsstat er en stat hvor domstolene er uavhengige av de politiske myndighetene, og hvor ingen skal kunne settes i fengsel eller straffes uten å ha fått prøvd saken sin for en domstol.', 11213, '2018-05-04T15:54:03Z', '2018-08-17T16:48:58Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('rettsstat', 'Ein rettsstat er ein stat der domstolane er uavhengige av dei politiske styresmaktene, og der ingen skal kunne setjast i fengsel eller straffast utan å ha fått prøvd saka si for ein domstol.', 11213, '2018-05-04T15:54:03Z', '2018-08-17T16:48:58Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sosialliberalisme', 'Sosialliberalisme er en politisk ideologi (tankesett) som vil gjennomføre sosiale reformer innenfor rammen av det privatkapitalistiske systemet. I teorien er individet et selvstendig vesen og samtidig sosialt avhengig. Staten bør derfor til en viss grad regulere samfunnsforholdene, men bare slik at det blir sosialt forsvarlig med individuell utfoldelse.', 11347, '2018-05-04T15:54:04Z', '2018-08-17T16:49:01Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sosialliberalisme', 'Sosialliberalisme er ein politisk ideologi (tankesett) som vil gjennomføre sosiale reformer innanfor ramma av det privatkapitalistiske systemet. I teorien er individet eit sjølvstendig vesen og samstundes sosialt avhengig. Staten bør derfor til ein viss grad regulere samfunnstilhøva, men berre slik at det blir sosialt forsvarleg med individuell utfalding.', 11347, '2018-05-04T15:54:04Z', '2018-08-17T16:49:01Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('pragmatisme', 'Pragmatisme er en holdning som innebærer at en retter seg etter de forhold som er.', 11333, '2018-05-04T15:54:05Z', '2018-08-17T16:49:02Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('pragmatisme', 'Pragmatisme er ei haldning som inneber at ein rettar seg etter dei tilhøva som er.', 11333, '2018-05-04T15:54:05Z', '2018-08-17T16:49:02Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('liberalisme', 'Liberalisme er en politisk ideologi (tankesett) som krever politisk, religiøs og økonomisk frihet for den enkelte uten statlig innblanding.', 11345, '2018-05-04T15:54:06Z', '2018-08-17T16:49:06Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('liberalisme', 'Liberalisme er ein politisk ideologi (tankesett) som krev politisk, religiøs og økonomisk fridom for den einskilde utan statleg innblanding.', 11345, '2018-05-04T15:54:06Z', '2018-08-17T16:49:06Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sosialisme', 'Sosialisme er en politisk ideologi (tankesett) som avviser privat eiendomsrett og hevder at produksjonsmidlene skal eies av samfunnet. Den tar avstand fra en kapitalistisk maktkonsentrasjon hos et fåtall, og har i stedet som mål en statlig planøkonomi som tilgodeser alle samfunnsmedlemmenes behov.', 11346, '2018-05-04T15:54:07Z', '2018-08-17T16:49:09Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '04.05.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sosialisme', 'Sosialisme er ein politisk ideologi (tankesett) som avviser privat eigedomsrett og meiner at samfunnet skal eige produksjonsmidla. Han tek avstand frå kapitalistisk maktkonsentrasjon hos eit fåtal. Målet er i staden ein statleg planøkonomi som gagnar behova til alle samfunnsmedlemene.', 11346, '2018-05-04T15:54:07Z', '2018-08-17T16:49:09Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '17.03.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ideologi', 'Ideologi er et tankesystem som gir uttrykk for et bestemt helhetlig syn på samfunnet. Ideologiene søker å gi svar på spørsmål om hvorfor samfunnet er blitt som det er, hvordan det bør være, hvilke generelle mål politikken bør ha, osv.', 6699, '2018-05-04T15:54:07Z', '2018-08-17T16:49:10Z', 'Gro-Anita Mortensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '17.03.2009', '22.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ideologi', 'Ideologi er eit tankesystem som gir uttrykk for eit bestemt heilskapleg syn på samfunnet. Ideologiane søkjer å gi svar på spørsmål om kvifor samfunnet er blitt som det er, korleis det bør vere, kva for generelle mål politikken bør ha, osb.', 6699, '2018-05-04T15:54:07Z', '2018-08-17T16:49:10Z', 'Gro-Anita Mortensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '08.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Utjevningsmandat', 'Utjevningsmandat er plasser i Stortinget som tildeles de partiene som i oppgjøret etter valget får få mandater i forhold til stemmetall. Det er 19 utjevningsmandater, ett for hvert fylke.', 11220, '2018-06-22T15:04:28Z', '2018-08-20T10:18:56Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '08.08.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Utjevningsmandat', 'Utjevningsmandat er plasser i Stortinget som tildeles de partiene som i oppgjøret etter valget får få mandater i forhold til stemmetall. Det er 19 utjevningsmandater, ett for hvert fylke.', 11220, '2018-06-22T15:04:28Z', '2018-08-20T10:18:56Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '15.02.2010', '09.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('mandat', 'Når en person, en organisasjon eller et utvalg får et mandat, betyr det at de får et bestemt oppdrag og fullmakt til å utføre det. De kan for eksempel få i oppdrag å utrede noe (finne ut av noe) eller styre et område. Et mandat kan også være et verv.', 50417, '2018-06-22T15:04:28Z', '2018-08-20T10:18:57Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '15.02.2010', '09.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('mandat', 'Når ein person, ein organisasjon eller eit utval får eit mandat, vil det seie at dei får eit særskilt oppdrag og fullmakt til å utføre det. Dei kan til dømes få i oppdrag å greie ut om noko (finne ut av noko) eller styre eit område. Eit mandat kan også vere eit verv.', 50417, '2018-06-22T15:04:28Z', '2018-08-20T10:18:57Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('konsultasjon', 'Det å konsultere betyr å søke råd hos en fagkyndig – en som er ekspert på et spesielt fagområde. Når det foregår konsultasjoner mellom to parter, for eksempel Sametinget og norske myndigheter, henvender de seg til hverandre for å spørre om råd og hjelp.', 50416, '2018-06-22T15:14:45Z', '2018-08-20T09:58:35Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('konsultasjon', 'Det å konsultere vil seie å søkje råd hos ein fagkyndig – ein som er ekspert på eit særskilt fagområde. Når konsultasjonar går føre seg mellom to partar, til dømes Sametinget og norske styresmakter, vender dei seg til kvarandre for å spørje om råd og hjelp.', 50416, '2018-06-22T15:14:45Z', '2018-08-20T09:58:35Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('høringsinstans', 'Det er vanlig at forslag fra forskjellige organisasjoner og instanser, blant annet regjeringen, blir sendt ut på høring. Det betyr at man vil ha skriftlige reaksjoner på forslaget. De som forslagene blir sendt ut på høring til, kalles høringsinstanser. Hvis for eksempel regjeringen fremmer et forslag som gjelder idrett, vil sannsynligvis Idrettsforbundet være en av høringsinstansene. Handler forslaget om noe som vil berøre de samiske områdene, er Sametinget en høringsinstans.', 50415, '2018-06-22T15:14:45Z', '2018-08-20T09:58:36Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('høyringsinstans', 'Det er vanleg at forslag frå ulike organisasjonar og instansar, mellom andre regjeringa, blir sende ut på høyring. Det tyder at ein vil ha skriftlege reaksjonar på forslaget. Dei som forslaga blir sende ut på høyring til, blir kalla høyringsinstansar. Om til dømes regjeringa fremjar eit forslag som gjeld idrett, vil sannsynlegvis Idrettsforbundet vere ein av høyringsinstansane. Handlar forslaget om noko som vil få verknad for dei samiske områda, er Sametinget ein høyringsinstans.', 50415, '2018-06-22T15:14:45Z', '2018-08-20T09:58:36Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('valgmanntall', 'Et valgmanntall er en oversikt over de personene som har rett til å stemme ved et bestemt valg. For eksempel har kommune- og fylkestingsvalg, stortingsvalg og sametingsvalg hver sine valgmanntall.', 50418, '2018-06-22T15:14:46Z', '2018-08-20T09:58:36Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('valmanntal', 'Eit valmanntal er eit oversyn over dei personane som har rett til å røyste ved eit særskilt val. Til dømes har kommune- og fylkestingsval, stortingsval og sametingsval kvar sine valmanntal.', 50418, '2018-06-22T15:14:46Z', '2018-08-20T09:58:36Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '10.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ratifiserte', 'Å ratifisere er når et land godkjenner en avtale, for eksempel en konvensjon. Når en avtale er ratifisert, er den bindende. De landene som har ratifisert en avtale, har altså forpliktet seg til å følge den.', 50204, '2018-06-22T15:14:47Z', '2018-08-20T09:58:38Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '10.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ratifiserte', 'Å ratifisere er når eit land godkjenner ein avtale, til dømes ein konvensjon. Når ein avtale er ratifisert, er han bindande. Dei landa som har ratifisert ein avtale, har altså forplikta seg til å følgje han.', 50204, '2018-06-22T15:14:47Z', '2018-08-20T09:58:38Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sedvanerett', 'Sedvane (eller seder/skikker) er måter vi opptrer på som er svært vanlige, men som ikke er bestemt i skriftlige regler. Det er altså uskrevne regler som er oppstått i samfunnet over tid, og som folk har rettet seg etter og for eksempel ser på som vanlig skikk og bruk. Sedvanerett er når en sedvane er så innarbeidet at den for eksempel kan brukes i en dom i en rettssak selv om den ikke er skrevet ned i noen lovtekst.', 50414, '2018-06-22T15:14:48Z', '2018-08-20T09:58:39Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '15.02.2010', '08.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sedvanerett', 'Sedvane (eller seder/skikkar) er måtar vi opptrer på som er svært vanlege, men som ikkje er fastsette i skriftlege reglar. Det er altså uskrivne reglar som er oppstått i samfunnet over tid, og som folk har retta seg etter og til dømes ser på som vanleg skikk og bruk. Sedvanerett er når ein sedvane er så innarbeidd at han til dømes kan brukast i ein dom i ei rettssak sjølv om han ikkje er skriven ned i nokon lovtekst.', 50414, '2018-06-22T15:14:48Z', '2018-08-20T09:58:39Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '21.09.2010', '07.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Resolusjon', 'En resolusjon er et vedtak eller en uttalelse som en forsamling har gjort i fellesskap, og som alle medlemmene av forsamlingen stiller seg bak. For eksempel vedtar FN mange resolusjoner, særlig i Generalforsamlingen og i Sikkerhetsrådet. Eksempler på FN-resolusjoner er resolusjon 55/56 fra 2000 som etablerte en prosess som skulle sikre at diamanter blir kjøpt fra konfliktfrie områder, og resolusjon 61/255 fra 2007 som fordømte enhver fornektelse av holocaust.', 61087, '2018-05-09T15:44:53Z', '2018-09-04T06:47:06Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '21.09.2010', '07.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Resolusjon', 'Ein resolusjon er eit vedtak eller ei fråsegn som ei forsamling har gjort i fellesskap, og som alle medlemmene av forsamlinga stiller seg bak. Til dømes vedtek FN mange resolusjonar, særleg i Generalforsamlinga og i Tryggingsrådet. Døme på FN-resolusjonar er resolusjon 55/56 frå 2000 som etablerte ein prosess som skulle sikre at diamantar blir kjøpte frå konfliktfrie område, og resolusjon 61/255 frå 2007 som fordømte all form for fornekting av holocaust.', 61087, '2018-05-09T15:44:53Z', '2018-09-04T06:47:06Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '05.03.2009', '06.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('normer', 'En norm er en regel eller et prinsipp som forbyr eller tillater en handling eller handlemåte. Det er en felles oppfattelse av hva som er godtatt eller ikke i et samfunn. Vi kan si at en norm er en rettesnor for hvordan vi skal oppføre oss. Normer kan være både formelle, nedskrevne lover og regler og uformelle og uskrevne. For eksempel har vi normer for bordskikk som ikke er skrevet ned.', 5352, '2018-06-22T15:08:50Z', '2018-08-20T10:28:43Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '05.03.2009', '06.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('normer', 'Ei norm er ein regel eller eit prinsipp som tillèt eller nektar ei handling eller ein handlemåte. Det er ei felles oppfatting av kva som er godteke eller ikkje i eit samfunn. Vi kan seie at ei norm er ei rettesnor for korleis vi skal oppføre oss. Normer kan vere både formelle, nedskrivne lover og reglar og uformelle og uskrivne. Til dømes har vi normer for bordskikk som ikkje er skrivne ned.', 5352, '2018-06-22T15:08:50Z', '2018-08-20T10:28:43Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '05.03.2009', '06.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('folkeretten', 'Folkerett er rettsregler som er bindende i forholdet mellom stater. Man regner også med at enkeltpersoner (individer) og internasjonale organisasjoner kan være bundet av folkeretten.', 5356, '2018-06-22T15:08:51Z', '2018-08-20T10:28:44Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '05.03.2009', '06.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('folkeretten', 'Folkerett er rettsreglar som er bindande i forholdet mellom statar. Ein reknar også med at einskildpersonar (individ) og internasjonale organisasjonar kan vere bundne av folkeretten.', 5356, '2018-06-22T15:08:51Z', '2018-08-20T10:28:44Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '13.04.2009', '06.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('legitimt', 'At noe er legitimt, betyr at det er rettmessig – noe som godtas som lovlig eller selvfølgelig.', 9091, '2018-06-22T15:08:51Z', '2018-08-20T10:28:45Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '13.04.2009', '06.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('legitimt', 'At noko er legitimt, tyder at det er rettmessig – noko som blir godteke som lovleg eller sjølvsagt.', 9091, '2018-06-22T15:08:51Z', '2018-08-20T10:28:45Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '20.06.2016', '05.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('EØS-avtalen', 'En avtale som Norge, Island og Liechtenstein har inngått med EU for å få tollfrihet for en rekke varer som vi ønsker å importere eller eksportere til land innenfor EU. Landbruksprodukter og fisk inngår ikke i EØS-avtalen.', 167207, '2018-05-27T23:05:11Z', '2018-08-20T10:26:19Z', 'Isak Nordeng Jensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '20.06.2016', '05.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('EØS-avtalen', 'Ein avtale som Noreg, Island og Liechtenstein har inngått med EU for å få tollfridom for ei rekkje varer som vi ønskjer å importere eller eksportere til land innanfor EU. Landbruksprodukt og fisk er ikkje med i EØS-avtalen.', 167207, '2018-05-27T23:05:11Z', '2018-08-20T10:26:19Z', 'Isak Nordeng Jensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '03.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('kabinettspørsmål', 'Når en regjering stiller kabinettspørsmål, betyr det at den truer med å gå av dersom forslaget det gjelder, ikke blir vedtatt i Stortinget.', 11257, '2018-05-09T15:17:33Z', '2018-09-04T08:51:48Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '03.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('kabinettspørsmål', 'Når ei regjering stiller kabinettspørsmål, tyder det at ho trugar med å gå av dersom forslaget det gjeld, ikkje blir vedteke i Stortinget.', 11257, '2018-05-09T15:17:33Z', '2018-09-04T08:51:48Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '03.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('direkte demokrati', 'Direkte demokrati betyr at folket gjennom valg kan ta stilling til konkrete saker. Folkeavstemninger er eksempler på direkte demokrati.', 11268, '2018-06-22T15:03:50Z', '2018-08-20T10:17:00Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '03.07.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('direkte demokrati', 'Direkte demokrati tyder at folket gjennom val kan ta stilling til konkrete saker. Folkerøystingar er døme på direkte demokrati.', 11268, '2018-06-22T15:03:50Z', '2018-08-20T10:17:00Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '30.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('representativt demokrati', 'Representativt demokrati er en demokratisk styreform der de som skal ta politiske beslutninger, er valgt av folket. Representativt demokrati kalles ofte også for indirekte demokrati.', 11212, '2018-06-22T15:03:25Z', '2018-08-20T10:19:17Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '30.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('representativt demokrati', 'Representativt demokrati er ei demokratisk styreform der dei som skal ta politiske avgjerder, er valde av folket. Representativt demokrati kallast ofte også for indirekte demokrati.', 11212, '2018-06-22T15:03:25Z', '2018-08-20T10:19:17Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '04.05.2009', '30.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sivil ulydighet', 'Sivil ulydighet er en politisk aksjonsform som bryter loven, eller som er brudd på andre offentlige bestemmelser. Lovbruddene må være ikkevoldelige og avgrenset til en bestemt sak.', 11301, '2018-06-22T15:03:03Z', '2018-08-20T10:11:28Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '04.05.2009', '30.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('sivil ulydnad', 'Sivil ulydnad er ei politisk aksjonsform som bryt lova, eller som er brot på andre offentlege føresegner. Lovbrota må vere ikkjevaldelege og avgrensa til ei bestemd sak.', 11301, '2018-06-22T15:03:03Z', '2018-08-20T10:11:28Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '11.02.2009', '29.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Konvensjon', 'En konvensjon er en avtale som også kan gå under navn som traktat eller pakt. Ofte er konvensjoner internasjonale. En internasjonal konvensjon er en avtale mellom stater hvor de statene som underskriver, forplikter seg til å respektere avtalen. Når en stat har skrevet under på en slik konvensjon, sier vi at staten har ratifisert konvensjonen. Da er konvensjonen folkerettslig bindende for den staten.', 3515, '2018-06-22T14:59:34Z', '2018-08-20T09:59:33Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '11.02.2009', '29.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Konvensjon', 'Ein konvensjon er ein avtale som også kan gå under namn som traktat eller pakt. Ofte er konvensjonar internasjonale. Ein internasjonal konvensjon er ein avtale mellom statar. Dei statane som skriv under, bind seg til å respektere avtalen. Når ein stat har skrive under på ein slik konvensjon, seier vi at staten har ratifisert konvensjonen. Da er konvensjonen folkerettsleg bindande for den staten.', 3515, '2018-06-22T14:59:34Z', '2018-08-20T09:59:33Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '25.02.2009', '29.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Ratifisert', 'Å ratifisere en avtale betyr å godkjenne den, eller å den gjøre gyldig. Hvis et land ratifiserer en avtale, betyr det at de godkjenner alle sider ved den og forplikter seg til å følge avtalen i ett og alt.', 4483, '2018-06-22T14:59:33Z', '2018-08-20T09:59:32Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '25.02.2009', '29.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Ratifisert', 'Å ratifisere ein avtale vil seie å godkjenne han, eller å gjere han gyldig. Om eit land ratifiserer ein avtale, tyder det at dei godkjenner alle sider ved han og bind seg til å følgje avtalen i eitt og alt.', 4483, '2018-06-22T14:59:33Z', '2018-08-20T09:59:32Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '20.04.2009', '29.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Assimilering', 'Assimilering betyr "å gjøre lik". Assimilering beskrives gjerne som en politikk som en stat eller regjering fører overfor en språklig og kulturell minoritet for å gjøre den mest mulig lik flertallet i befolkningen. I Norge ble denne politikken ført overfor samene. Vi refererer også ofte til det som en fornorskningsprosess.', 9710, '2018-05-04T21:29:02Z', '2018-09-04T08:50:57Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '20.04.2009', '29.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Assimilering', 'Assimilering tyder "å gjere lik". Assimilering blir gjerne forklart som ein politikk som ein stat eller ei regjering fører overfor ein språkleg og kulturell minoritet for å gjere han mest mogleg lik fleirtalet i befolkninga. I Noreg blei denne politikken ført overfor samane. Vi refererer også ofte til det som ein fornorskingsprosess.', 9710, '2018-05-04T21:29:02Z', '2018-09-04T08:50:57Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '23.02.2009', '12.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Hovedavtalen', 'Hovedavtalen (ofte kalt tariffavtalens del 1) er en avtale mellom arbeidsgiverorganisasjoner og arbeidstakerorganisasjoner. Den inneholder generelle bestemmelser om forhandlings- og samarbeidsforhold, men sier ikke noe om for eksempel lønn. Hovedavtalen kan for eksempel handle om de ansattes rett til informasjon, medbestemmelse og innsyn, og sikre retten til å ha tillitsvalgte som opptrer på arbeidstakernes vegne. Den sikrer også tillitsvalgte mot usaklig oppsigelse og trekker opp hvilke spilleregler som gjelder på arbeidsplassen for informasjon, samarbeid og konfliktløsning. Hovedavtalen gjelder normalt for fire år av gangen. Hovedavtalen i arbeidslivet er styrende for reguleringen av andre avtaler. Den første hovedavtalen i Norge ble inngått i 1935 mellom LO og N.A.F. (senere NHO). Kilde: Wikipedia', 4228, '2018-05-09T15:21:18Z', '2018-09-04T08:52:05Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '23.02.2009', '12.06.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Hovudavtalen', 'Hovudavtalen (ofte kalla tariffavtalens del 1) er ein avtale mellom arbeidsgivarorganisasjonar og arbeidstakarorganisasjonar. Han inneheld generelle avtalepunkt om forhandlings- og samarbeidstilhøve, men seier ikkje noko om til dømes løn. Hovudavtalen kan til dømes handle om dei tilsette sin rett til informasjon, medråderett og innsyn, og sikre retten til å ha tillitsvalde som opptrer på vegner av arbeidstakarane. Han sikrar også tillitsvalde mot usakleg oppseiing og trekkjer opp kva for spelereglar som gjeld på arbeidsplassen for informasjon, samarbeid og konfliktløysing. Hovudavtalen gjeld normalt for fire år av gangen. Hovudavtalen i arbeidslivet er styrande for reguleringa av andre avtalar. Den første hovudavtalen i Noreg blei inngått i 1935 mellom LO og N.A.F. (seinare NHO). Kjelde: Wikipedia', 4228, '2018-05-09T15:21:18Z', '2018-09-04T08:52:05Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '04.06.2015', '23.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('artikulert', 'artikulert plattform; en plattform, f.eks. for lasting til havs, som er festet til et forankringspunkt på havbunnen via et kardangledd, slik at plattformen kan gi etter for strøm og vind uten å ta skade (SNL).', 145913, '2018-06-22T15:43:44Z', '2018-09-04T08:43:55Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '04.06.2015', '23.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('artikulert', 'artikulert plattform; en plattform, f.eks. for lasting til havs, som er festet til et forankringspunkt på havbunnen via et kardangledd, slik at plattformen kan gi etter for strøm og vind uten å ta skade (SNL).', 145913, '2018-06-22T15:43:44Z', '2018-09-04T08:43:55Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '23.05.2017', '23.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('DHSV', 'DHSV er forkortet fra Down Hole Safety Valve. Det er en ventil som monteres i øvre del av brønnen i produksjonsrøret. Ventilen holdes åpen av trykk gjennom en kontrollinje. Den er «fail safe close», som betyr at den stenger dersom trykket i kontrollinjen faller under et minimumsnivå. Ventilen er primærbarrieren i en produserende brønn.', 178527, '2018-06-22T15:37:42Z', '2018-09-04T08:43:46Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '23.05.2017', '23.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('DHSV', 'DHSV er forkortet fra Down Hole Safety Valve. Det er en ventil som monteres i øvre del av brønnen i produksjonsrøret. Ventilen holdes åpen av trykk gjennom en kontrollinje. Den er «fail safe close», som betyr at den stenger dersom trykket i kontrollinjen faller under et minimumsnivå. Ventilen er primærbarrieren i en produserende brønn.', 178527, '2018-06-22T15:37:42Z', '2018-09-04T08:43:46Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '16.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('P/A', 'P/A: Plug and Abandon. Når BOP eller ventiltre skal fjernes fra brønnen (etter borefase eller produksjonsfase), må brønnen sikres med to plugger: en dyp og en grunn. I noen tilfeller er det en midlertidig plugging (temporary abandonment), andre ganger er det en permanent plugging.', 177669, '2018-06-22T15:37:43Z', '2018-09-04T08:43:46Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '16.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('P/A', 'P/A: Plug and Abandon. Når BOP eller ventiltre skal fjernes fra brønnen (etter borefase eller produksjonsfase), må brønnen sikres med to plugger: en dyp og en grunn. I noen tilfeller er det en midlertidig plugging (temporary abandonment), andre ganger er det en permanent plugging.', 177669, '2018-06-22T15:37:43Z', '2018-09-04T08:43:46Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '08.05.2017', '12.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Perforere en brønn', 'Å perforere en brønn vil si at det skytes flere hull i røret som skiller brønnen fra reservoaret. Perforering utføres ved hjelp av mange små eksplosiver som aktiviseres når de er kjørt inn i brønnen til riktig sted.', 177921, '2018-06-22T15:44:54Z', '2018-09-04T08:43:52Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '08.05.2017', '12.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Perforere en brønn', 'Å perforere en brønn vil si at det skytes flere hull i røret som skiller brønnen fra reservoaret. Perforering utføres ved hjelp av mange små eksplosiver som aktiviseres når de er kjørt inn i brønnen til riktig sted.', 177921, '2018-06-22T15:44:54Z', '2018-09-04T08:43:52Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '11.05.2017', '11.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Assembly', 'Assembly er engelsk og betyr montering. Ordet brukes om komponenter som monteres sammen i en lengre enhet for å brukes til boring eller brønnaktiviteter. Et assembly dokumenteres på en liste med tekst og tegning som viser hvor hver komponent er, og de ytre og indre målene.', 178004, '2018-06-22T15:41:06Z', '2018-09-04T08:44:06Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '11.05.2017', '11.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Assembly', 'Assembly er engelsk og betyr montering. Ordet brukes om komponenter som monteres sammen i en lengre enhet for å brukes til boring eller brønnaktiviteter. Et assembly dokumenteres på en liste med tekst og tegning som viser hvor hver komponent er, og de ytre og indre målene.', 178004, '2018-06-22T15:41:06Z', '2018-09-04T08:44:06Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '11.05.2017', '11.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fiskenakke', 'Fiskenakken er utformingen i den øvre delen av hver komponent. Den skal være utformet slik at det er mulig å ta tak i komponenten med et fiskevertøy og hente komponenten ut av brønnen.', 178002, '2018-06-22T15:44:46Z', '2018-09-04T08:44:04Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '11.05.2017', '11.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fiskenakke', 'Fiskenakken er utformingen i den øvre delen av hver komponent. Den skal være utformet slik at det er mulig å ta tak i komponenten med et fiskevertøy og hente komponenten ut av brønnen.', 178002, '2018-06-22T15:44:46Z', '2018-09-04T08:44:04Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '08.05.2017', '10.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Svivel', 'Svivel er en rørkobling som er delt i to med pakning i overgangen. Svivelen gjør at den ene siden av koblingen kan rotere uten at den andre enden følger med.', 177923, '2018-06-22T15:44:59Z', '2018-09-04T08:43:56Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '08.05.2017', '10.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Svivel', 'Svivel er en rørkobling som er delt i to med pakning i overgangen. Svivelen gjør at den ene siden av koblingen kan rotere uten at den andre enden følger med.', 177923, '2018-06-22T15:44:59Z', '2018-09-04T08:43:56Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '08.05.2017', '09.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pin og box-gjenger', 'Pin og box er engelske uttrykk for utvendige og innvendige gjenger. Andre uttrykk er male og female: hann- og hunngjenger.', 177900, '2018-06-22T15:37:45Z', '2018-09-04T08:43:30Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '08.05.2017', '09.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pin og box-gjenger', 'Pin og box er engelske uttrykk for utvendige og innvendige gjenger. Andre uttrykk er male og female: hann- og hunngjenger.', 177900, '2018-06-22T15:37:45Z', '2018-09-04T08:43:30Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('PDC-bit', 'PDC-bit er engelsk forkortelse for Polycrystalline Diamond Compact. Det er en borekrone med kunstige diamanter som kutter og maler formasjonen. Den har ingen roterende deler.', 177850, '2018-06-22T15:37:48Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('PDC-bit', 'PDC-bit er engelsk forkortelse for Polycrystalline Diamond Compact. Det er en borekrone med kunstige diamanter som kutter og maler formasjonen. Den har ingen roterende deler.', 177850, '2018-06-22T15:37:48Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Roller cone bit', 'Roller cone bit, også kjent som rock bit, er en borekrone med tre kjegler som ruller mot formasjonen og knuser den til mindre biter. På norsk kalles den ofte rulleborekrone.', 177837, '2018-06-22T15:37:56Z', '2018-09-04T08:44:06Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Roller cone bit', 'Roller cone bit, også kjent som rock bit, er en borekrone med tre kjegler som ruller mot formasjonen og knuser den til mindre biter. På norsk kalles den ofte rulleborekrone.', 177837, '2018-06-22T15:37:56Z', '2018-09-04T08:44:06Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Riser (stigerør)', 'Riser er det engelske ordet for stigerør. Riser er en midlertidig rørforlengelse av brønnen fra brønnhodet til overflaten (rigg). Det finnes ulike typer riser: drilling riser med stor dimensjon, work-over riser med noe mindre dimensjon, og production riser som er en permanent forlengelse av brønnen.', 177831, '2018-06-22T15:37:52Z', '2018-09-04T08:43:55Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Riser (stigerør)', 'Riser er det engelske ordet for stigerør. Riser er en midlertidig rørforlengelse av brønnen fra brønnhodet til overflaten (rigg). Det finnes ulike typer riser: drilling riser med stor dimensjon, work-over riser med noe mindre dimensjon, og production riser som er en permanent forlengelse av brønnen.', 177831, '2018-06-22T15:37:52Z', '2018-09-04T08:43:55Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '04.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kick off point (KOP)', 'Kick off point (KOP) er det dypet i brønnen der vinkelen skal økes eller reduseres fra den retningen brønnen har. En brønn kan ha mange KOP, ett for hver retningsendring.', 177789, '2018-06-22T15:37:54Z', '2018-09-04T08:44:01Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '04.05.2017', '08.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kick off point (KOP)', 'Kick off point (KOP) er det dypet i brønnen der vinkelen skal økes eller reduseres fra den retningen brønnen har. En brønn kan ha mange KOP, ett for hver retningsendring.', 177789, '2018-06-22T15:37:54Z', '2018-09-04T08:44:01Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '02.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('LOT', 'LOT; Leak Off Test. Trykktest av formasjonsstyrken. Trykket økes til formasjonen begynner å lekke. Trykket som oppnås er grenseverdien for belastning mot formasjonen og skal ikke overskrides i videre operasjon i brønnen.', 177667, '2018-06-22T15:38:17Z', '2018-09-04T08:43:31Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '02.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('LOT', 'LOT; Leak Off Test. Trykktest av formasjonsstyrken. Trykket økes til formasjonen begynner å lekke. Trykket som oppnås er grenseverdien for belastning mot formasjonen og skal ikke overskrides i videre operasjon i brønnen.', 177667, '2018-06-22T15:38:17Z', '2018-09-04T08:43:31Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '02.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('FIT', 'FIT; Formation Integrity Test. En trykktest som tester om formasjonen tåler et tilført trykk uten å lekke. FIT skal ikke teste ved hvilket trykk formasjonen sprekker.', 177664, '2018-06-22T15:37:57Z', '2018-09-04T08:44:13Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '02.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('FIT', 'FIT; Formation Integrity Test. En trykktest som tester om formasjonen tåler et tilført trykk uten å lekke. FIT skal ikke teste ved hvilket trykk formasjonen sprekker.', 177664, '2018-06-22T15:37:57Z', '2018-09-04T08:44:13Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '02.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('HPHT', 'HPHT; high pressure high temperature. Brønner der poretrykket er over 690 bar og temperaturen er høyere enn 150 °C. Noen brønner kan være enten HP eller HT.', 177663, '2018-06-22T15:38:19Z', '2018-09-04T08:43:41Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '02.05.2017', '02.05.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('HPHT', 'HPHT; high pressure high temperature. Brønner der poretrykket er over 690 bar og temperaturen er høyere enn 150 °C. Noen brønner kan være enten HP eller HT.', 177663, '2018-06-22T15:38:19Z', '2018-09-04T08:43:41Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '26.04.2017', '27.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Dispergeringsmiddel', 'Dispersjon betyr «en finfordelt spredning». Dispergeringsmidler gjør at uløselige, finknuste partikler kan spres og sveve jevnt fordelt i en væske.', 177523, '2018-06-22T15:38:14Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '26.04.2017', '27.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Dispergeringsmiddel', 'Dispersjon betyr «en finfordelt spredning». Dispergeringsmidler gjør at uløselige, finknuste partikler kan spres og sveve jevnt fordelt i en væske.', 177523, '2018-06-22T15:38:14Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '20.01.2017', '10.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brukeropplevelse/UX', 'Brukeropplevelse av hvordan det er å bevege seg i og bruke funksjonene i et grensesnitt.', 173847, '2018-05-04T14:09:28Z', '2018-05-27T15:36:18Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '20.01.2017', '10.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brukaroppleving/UX', 'Brukaroppleving er korleis det er å bevege seg i og bruke funksjonane i eit grensesnitt.', 173847, '2018-05-04T14:09:28Z', '2018-05-27T15:36:18Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brukergrensesnitt/UI', 'Brukergrensesnitt er måten maskinen og programmet kommuniserer med brukeren på. Brukergrensesnittet består av menyer og ikoner, hurtigtaster, så vel som input-enheter som tastatur og mus.', 173846, '2018-05-04T14:09:27Z', '2018-05-27T15:36:18Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brukargrensesnitt/UI', 'Brukargrensesnitt er måten maskinen og programmet kommuniserer med brukaren på. Brukargrensesnittet består av menyar og ikon, hurtigtastar, så vel som input-einingar som tastatur og mus.', 173846, '2018-05-04T14:09:27Z', '2018-05-27T15:36:18Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Personas', 'Personas er liksompersoner definert ut fra ulik alder, kjønn og interesser, som brukes for å undersøke hvordan ulike brukere opplever navigasjonen på et nettsted. Personas brukes i planlegging av nettsteder og app-er.', 173858, '2018-05-04T14:09:25Z', '2018-05-27T15:36:16Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Personas', 'Personas er liksompersonar definerte ut frå ulik alder, kjønn og interesser, som blir brukte for å undersøkje korleis ulike brukarar opplever navigasjonen på ein nettstad. Personas blir brukt i planlegging av nettstader og app-ar.', 173858, '2018-05-04T14:09:25Z', '2018-05-27T15:36:16Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brukersti', 'En brukersti er en forestilling om hvordan en typisk person vil komme til å bruke et nettsted, lete og finne fram. Brukerstier brukes i planlegging av nettsteder og app-er.', 173857, '2018-05-04T14:09:26Z', '2018-05-27T15:36:17Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brukarsti', 'Ein brukarsti er ei førestilling om korleis ein typisk person vil komme til å bruke ein nettstad, leite og finne fram. Brukarstiar blir brukte i planlegging av nettstader og app-ar.', 173857, '2018-05-04T14:09:26Z', '2018-05-27T15:36:17Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('App', 'App, forkortelse for «applikasjon», er en programvareløsning laget for å kjøre på smarttelefoner og nettbrett; noen apper, kalt web apps, kjører på nettet.', 173856, '2018-05-04T14:09:27Z', '2018-05-27T15:36:17Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('App', 'App, forkorting for «applikasjon», er ei programvareløysing laga for å køyre på smarttelefonar og nettbrett; nokre appar, kalla web apps, køyrer på nettet.', 173856, '2018-05-04T14:09:27Z', '2018-05-27T15:36:17Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Universell utforming/UU', 'Universell utforming er å forme omgivelsene slik at vi tar hensyn til variasjonen i funksjonsevne hos innbyggerne, inkludert personer med nedsatt funksjonsevne.', 173854, '2018-05-04T14:09:27Z', '2018-05-27T15:36:18Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Medieuttrykk og mediesamfunnet"}', '20.01.2017', '07.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Universell utforming/UU', 'Universell utforming er å forme omgjevnadene slik at vi tek omsyn til variasjonen i funksjonsevne hos innbyggjarane, inkludert personar med nedsett funksjonsevne.', 173854, '2018-05-04T14:09:27Z', '2018-05-27T15:36:18Z', 'Johannes Leiknes Nag', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '03.04.2017', '05.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('MWD', 'MWD er forkortelse for Measurement While Drilling. Det er et verktøy som brukes i bunnen av borestrengen (i BHA) til å registrere retningen på brønnbanen. Retningen registreres både vertikalt og horisontalt. Informasjonen om retningen sendes til overflaten gjennom pulser i boreslammet. På overflaten ser retningsboreren brønnbanen på en skjerm.', 176573, '2018-06-22T15:35:27Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '03.04.2017', '05.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('MWD', 'MWD er forkortelse for Measurement While Drilling. Det er et verktøy som brukes i bunnen av borestrengen (i BHA) til å registrere retningen på brønnbanen. Retningen registreres både vertikalt og horisontalt. Informasjonen om retningen sendes til overflaten gjennom pulser i boreslammet. På overflaten ser retningsboreren brønnbanen på en skjerm.', 176573, '2018-06-22T15:35:27Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '03.04.2017', '05.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('CBL', 'CBL er en forkortelse for Cement Bond Log. Loggen viser toppen av sementen, om det er hull i sementen eller mangler sement i noen områder. Loggen utføres på kabel og bruker lydsignaler (acoustic sonic log) som loggemedium.', 176572, '2018-06-22T15:37:49Z', '2018-09-04T08:43:39Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '03.04.2017', '05.04.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('CBL', 'CBL er en forkortelse for Cement Bond Log. Loggen viser toppen av sementen, om det er hull i sementen eller mangler sement i noen områder. Loggen utføres på kabel og bruker lydsignaler (acoustic sonic log) som loggemedium.', 176572, '2018-06-22T15:37:49Z', '2018-09-04T08:43:39Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '08.03.2017', '09.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Overlagring', 'Overlagring beskriver hvordan lag på lag med avsetninger og sedimentære bergarter ligger over en bergart i dypet.', 175464, '2018-06-22T15:28:58Z', '2018-08-17T14:15:16Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '08.03.2017', '09.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Overlagring', 'Overlagring beskriver hvordan lag på lag med avsetninger og sedimentære bergarter ligger over en bergart i dypet.', 175464, '2018-06-22T15:28:58Z', '2018-08-17T14:15:16Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '08.03.2017', '09.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Delta', 'Delta dannes av elveavsetninger (elvedelta, elveos). I området der elven ender i stillestående vann eller hav, avsettes sedimenter som danner kanaler og endringer i retningene utløpet tar. Typiske former er vifteform og fuglefot.', 175462, '2018-06-22T15:28:47Z', '2018-08-17T14:15:27Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '08.03.2017', '09.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Delta', 'Delta dannes av elveavsetninger (elvedelta, elveos). I området der elven ender i stillestående vann eller hav, avsettes sedimenter som danner kanaler og endringer i retningene utløpet tar. Typiske former er vifteform og fuglefot.', 175462, '2018-06-22T15:28:47Z', '2018-08-17T14:15:27Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '07.03.2017', '09.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Casing', 'Casing er engelsk og betyr fôringsrør. Rørene skrus sammen og brukes til å sikre borehullet. Casingen går helt opp i brønnen. For hver nye seksjon som bores ut, installeres en mindre casing innvendig i den forrige. Casing sementeres i nederste del. Casing skilles fra andre rør på størrelsen, mindre rør kalles tubing på engelsk.', 175426, '2018-06-22T15:37:45Z', '2018-09-04T08:44:14Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '07.03.2017', '09.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Casing', 'Casing er engelsk og betyr fôringsrør. Rørene skrus sammen og brukes til å sikre borehullet. Casingen går helt opp i brønnen. For hver nye seksjon som bores ut, installeres en mindre casing innvendig i den forrige. Casing sementeres i nederste del. Casing skilles fra andre rør på størrelsen, mindre rør kalles tubing på engelsk.', 175426, '2018-06-22T15:37:45Z', '2018-09-04T08:44:14Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '07.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Tariffavtale', 'Avtale mellom en fagforening og en arbeidsgiver om arbeids- og lønnsvilkår. En tariffavtale gjelder for en bestemt tidsperiode og er forskjellig fra bransje til bransje.', 167361, '2018-05-27T16:37:10Z', '2018-09-04T08:50:56Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '07.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Tariffavtale', 'Avtale mellom ei fagforeining og ein arbeidsgivar om arbeids- og lønnsvilkår. Ein tariffavtale gjeld for ein bestemt tidsperiode og er ulik frå bransje til bransje.', 167361, '2018-05-27T16:37:10Z', '2018-09-04T08:50:56Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '02.03.2017', '07.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Forvitring', 'Forvitring kommer fra det tyske ordet «Wetter» som betyr vær. På engelsk omtales forvitring som "weathering". Forvitring er altså nedbryting av bergarter på grunn av vær: vann, vind og temperatur.', 175244, '2018-06-22T15:28:45Z', '2018-08-17T14:12:47Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '02.03.2017', '07.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Forvitring', 'Forvitring kommer fra det tyske ordet «Wetter» som betyr vær. På engelsk omtales forvitring som "weathering". Forvitring er altså nedbryting av bergarter på grunn av vær: vann, vind og temperatur.', 175244, '2018-06-22T15:28:45Z', '2018-08-17T14:12:47Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Biologi 1"}', '28.05.2014', '05.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Polare vassmolekyl', 'Vassmolekyl er polare. Det vil seie at dei har ei ladningsforskyving, men ingen netto ladning. Vassmolekyl har ei positiv og ei negativ side (pol), fordi oksygen og hydrogen trekkjer ulikt på dei felles elektronpara.', 134394, '2018-06-22T15:36:00Z', '2018-09-04T08:43:33Z', 'Kristin Bøhle', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Biologi 1"}', '28.05.2014', '05.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Polare vannmolekyler', 'Vannmolekyler er polare. Det vil si at de har en ladningsforskyvning, men ingen netto ladning. Vannmolekyler har en positiv og negativ side (pol) fordi oksygen og hydrogen trekker ulikt på de felles elektronparene.', 134394, '2018-06-22T15:36:00Z', '2018-09-04T08:43:33Z', 'Kristin Bøhle', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Digital kompetanse"}', '11.01.2010', '03.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Primitiv', 'Eit problem du kan løyse enkelt, raskt og nøyaktig. Ein ”byggjestein” som du kan bruke når du skal løyse meir komplekse problem. Du deler opp hovudproblemet i mindre primitivar, og løyser dei enkelt. Eit døme på ein primitiv er gongetabellen. Har du lært han, slepp du å tenkje på korleis du løyser 8 x 7. Du veit med ein gong at det er 56. Sjå òg', 48108, '2018-05-04T14:59:12Z', '2018-05-04T15:00:05Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Digital kompetanse"}', '11.01.2010', '03.03.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Primitiv', 'Et problem du kan løse enkelt, raskt og nøyaktig. En ”byggestein” som du kan bruke når du skal løse mer komplekse problemer. Du deler opp hovedproblemet i mindre primitiver og løser dem enkelt. Et eksempel på en primitiv er gangetabellen. Har du lært den, slipper du å tenke på hvordan du løser 8 x 7. Du vet med en gang at det er 56. Se også', 48108, '2018-05-04T14:59:12Z', '2018-05-04T15:00:05Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '06.02.2017', '26.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Primærbarriere', 'Primærbarrieren i en brønn er den hindringen som ligger nærmest kilden (reservoaret). I forbindelse med bore- og brønnaktivitet er primærbarrieren væsken som står i brønnen. Når brønnen produserer, er det kompletteringen med sikringsventilen (DHSV) i brønnen som er primærbarrieren.', 174263, '2018-06-22T15:37:31Z', '2018-09-04T08:44:03Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '06.02.2017', '26.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Primærbarriere', 'Primærbarrieren i en brønn er den hindringen som ligger nærmest kilden (reservoaret). I forbindelse med bore- og brønnaktivitet er primærbarrieren væsken som står i brønnen. Når brønnen produserer, er det kompletteringen med sikringsventilen (DHSV) i brønnen som er primærbarrieren.', 174263, '2018-06-22T15:37:31Z', '2018-09-04T08:44:03Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '06.02.2017', '13.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Sikkerhetsmargin ', 'Sikkerhetsmargin er et tillegg over eller under et mål som gjør at man har noe spillerom før grensen er nådd.', 174241, '2018-06-22T15:37:25Z', '2018-09-04T08:43:47Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '06.02.2017', '13.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Sikkerhetsmargin ', 'Sikkerhetsmargin er et tillegg over eller under et mål som gjør at man har noe spillerom før grensen er nådd.', 174241, '2018-06-22T15:37:25Z', '2018-09-04T08:43:47Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '06.02.2017', '13.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Choke line og kill line på BOP', 'Choke line og kill line i BOP er linjer (rør) som går inn i BOP fra overflaten. Linjene brukes til å sirkulere væske inn og ut fra ringrommet når en ventil i BOP er stengt over koblingspunktet til choke line og kill line. Choke line brukes til utsirkulering, og kill line til innsirkulering av væske.', 174238, '2018-06-22T15:37:30Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '06.02.2017', '13.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Choke line og kill line på BOP', 'Choke line og kill line i BOP er linjer (rør) som går inn i BOP fra overflaten. Linjene brukes til å sirkulere væske inn og ut fra ringrommet når en ventil i BOP er stengt over koblingspunktet til choke line og kill line. Choke line brukes til utsirkulering, og kill line til innsirkulering av væske.', 174238, '2018-06-22T15:37:30Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '03.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kontantstøtte', 'En pengestøtte som blir gitt til foreldre med barn mellom ett og to år som ikke går i barnehage. Støtten kan tidligst bli gitt fra måneden etter at barnet har fylt ett år, og kan maksimalt gis til og med måneden før barnet fyller to år, dvs. maksimalt 11 måneder.', 167266, '2018-06-22T15:06:20Z', '2018-08-17T19:10:43Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '03.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kontantstøtte', 'Ei pengestøtte som blir gitt til foreldre med barn mellom eitt og to år som ikkje går i barnehage. Støtta kan tidlegast bli gitt frå månaden etter at barnet har fylt eitt år, og kan maksimalt bli utbetalt til og med månaden før barnet fyller to år, dvs. maksimalt 11 månader.', 167266, '2018-06-22T15:06:20Z', '2018-08-17T19:10:43Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '20.06.2016', '03.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Engangsstønad', 'Mødre kan få engangsstønad ved fødsel og adopsjon hvis de ikke har rett til foreldrepenger. Hvis en far er alene om omsorgen, kan også han ha rett til engangsstønad.', 167189, '2018-06-22T15:06:21Z', '2018-08-17T19:10:46Z', 'Isak Nordeng Jensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '20.06.2016', '03.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Eingongsstønad', 'Mødrer kan få eingongsstønad ved fødsel og adopsjon dersom dei ikkje har rett til foreldrepengar. Dersom ein far er åleine om omsorga, kan også han ha rett til eingongsstønad.', 167189, '2018-06-22T15:06:21Z', '2018-08-17T19:10:46Z', 'Isak Nordeng Jensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '27.01.2017', '01.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Geologiske lag', 'Geologiske lag er lagene som dannes gjennom millioner av år av ulike typer sedimenter som er avsatt på havbunnen. Sedimentene er da blitt omdannet til forskjellige bergarter som ligger lag på lag. Skillet mellom disse ulike bergartene er grensene som påvises i seismiske undersøkelser. Dypet og vinkelen til disse grensene er endret fra opprinnelig posisjon på grunn av blant annet foldinger, forkastninger og saltdiapirer.', 173987, '2018-06-22T15:29:38Z', '2018-08-17T14:17:19Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '27.01.2017', '01.02.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Geologiske lag', 'Geologiske lag er lagene som dannes gjennom millioner av år av ulike typer sedimenter som er avsatt på havbunnen. Sedimentene er da blitt omdannet til forskjellige bergarter som ligger lag på lag. Skillet mellom disse ulike bergartene er grensene som påvises i seismiske undersøkelser. Dypet og vinkelen til disse grensene er endret fra opprinnelig posisjon på grunn av blant annet foldinger, forkastninger og saltdiapirer.', 173987, '2018-06-22T15:29:38Z', '2018-08-17T14:17:19Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '28.12.2016', '12.01.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ROV', 'Fjernstyrt undervannsfarkost (ROV, fra engelsk Remotely Operated Vehicle) er en robot som blir fjernstyrt fra kontrollrom på skip eller plattform. ROV brukes til kartlegging av havbunn, inspeksjon, vedlikehold og reparasjon av havbunnsinstallasjoner og lignende. Den kan operere ned til ca. 3000 meter og i helt spesielle tilfeller ned til 7000–8000 meter. Fjernstyrte undervannsfarkoster utfører i dag mange oppgaver som før krevde dykkere. Operatøren som flyr en ROV, kalles pilot.', 173533, '2018-06-22T15:37:55Z', '2018-09-04T08:44:04Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '28.12.2016', '12.01.2017') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ROV', 'Fjernstyrt undervannsfarkost (ROV, fra engelsk Remotely Operated Vehicle) er en robot som blir fjernstyrt fra kontrollrom på skip eller plattform. ROV brukes til kartlegging av havbunn, inspeksjon, vedlikehold og reparasjon av havbunnsinstallasjoner og lignende. Den kan operere ned til ca. 3000 meter og i helt spesielle tilfeller ned til 7000–8000 meter. Fjernstyrte undervannsfarkoster utfører i dag mange oppgaver som før krevde dykkere. Operatøren som flyr en ROV, kalles pilot.', 173533, '2018-06-22T15:37:55Z', '2018-09-04T08:44:04Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '28.12.2016', '28.12.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Litologi', 'Av de greske ordene lithos; stein og logi; lære). Beskrivelse og klassifikasjon av bergarter, særlig sedimentære bergarter som sandstein, kalkstein og leirskifer.', 173531, '2018-06-22T15:35:40Z', '2018-09-04T08:43:44Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '28.12.2016', '28.12.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Litologi', 'Av de greske ordene lithos; stein og logi; lære). Beskrivelse og klassifikasjon av bergarter, særlig sedimentære bergarter som sandstein, kalkstein og leirskifer.', 173531, '2018-06-22T15:35:40Z', '2018-09-04T08:43:44Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '04.12.2016', '09.12.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('GOC – gas-oil contact', 'GOC, gas-oil contact, viser til dybden i et reservoar der bunnen av gassen møter toppen av oljen.', 172924, '2018-07-06T14:42:41Z', '2018-09-04T08:43:28Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '04.12.2016', '09.12.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('GOC – gas-oil contact', 'GOC, gas-oil contact, viser til dybden i et reservoar der bunnen av gassen møter toppen av oljen.', 172924, '2018-07-06T14:42:41Z', '2018-09-04T08:43:28Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '04.12.2016', '07.12.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('OWC – oil-water contact', 'OWC, oil-water contact, viser til dybden i et reservoar der bunnen av oljen møter toppen av formasjonsvannet. OWC flytter seg oppover eller mot brønnen når reservoaret dreneres for olje.', 172923, '2018-07-06T14:42:42Z', '2018-09-04T08:43:31Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '04.12.2016', '07.12.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('OWC – oil-water contact', 'OWC, oil-water contact, viser til dybden i et reservoar der bunnen av oljen møter toppen av formasjonsvannet. OWC flytter seg oppover eller mot brønnen når reservoaret dreneres for olje.', 172923, '2018-07-06T14:42:42Z', '2018-09-04T08:43:31Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '24.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kryssproduksjon ', 'Kryssproduksjon er når en brønn har høyere trykk enn en annen, slik at produsert væske går ned i lavtrykkbrønnen i stedet for videre inn i produksjonsrøret. Kryssproduksjonen skjer i møtepunktet mellom brønnene (manifolden) før videre transport til produksjonsrøret. For å hindre kryssproduksjon kan man strupe produksjonen fra høytrykksbrønnen foran manifolden.', 172660, '2018-06-22T15:42:26Z', '2018-09-04T08:43:42Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '24.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kryssproduksjon ', 'Kryssproduksjon er når en brønn har høyere trykk enn en annen, slik at produsert væske går ned i lavtrykkbrønnen i stedet for videre inn i produksjonsrøret. Kryssproduksjonen skjer i møtepunktet mellom brønnene (manifolden) før videre transport til produksjonsrøret. For å hindre kryssproduksjon kan man strupe produksjonen fra høytrykksbrønnen foran manifolden.', 172660, '2018-06-22T15:42:26Z', '2018-09-04T08:43:42Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '25.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pilothull ', 'Pilothull kommer fra det engelske verbet to pilot; å lede. Pilothull er boring av et hull i to steg, først med liten diameter, deretter med den større diameteren. Et pilothull bores i områder med ukjente forhold. Dersom det er gass vil konsekvensene av en utstrømning være betydelig mindre, enn med stort hull. Det er også lettere å gjenvinne kontrollen med å pumpe væske med høy hastighet i et lite hull, fordi det skaper friksjon som virker mot utstrømningen.', 172679, '2018-06-22T15:34:47Z', '2018-09-04T08:43:39Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '25.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pilothull ', 'Pilothull kommer fra det engelske verbet to pilot; å lede. Pilothull er boring av et hull i to steg, først med liten diameter, deretter med den større diameteren. Et pilothull bores i områder med ukjente forhold. Dersom det er gass, vil konsekvensene av en utstrømning være betydelig mindre enn med stort hull. Det er også lettere å gjenvinne kontrollen med å pumpe væske med høy hastighet i et lite hull, fordi det skaper friksjon som virker mot utstrømningen.', 172679, '2018-06-22T15:34:47Z', '2018-09-04T08:43:39Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '25.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Boreparameter ', 'Boreparameter er et samlebegrep for verdier som er viktige å overvåke under boring. De vanligste vi overvåker, er framdriften, rate of penetration (ROP), vekten på borekronen, weight on bit (WOB), og friksjonen mot rotasjon på borekronen, torque. Endringer i boreparametrene som ikke er forårsaket av endringer fra borerens kontrollpanel, kan bety at man borer inn i høytrykksone eller får kick inn i brønnen.', 172685, '2018-06-22T15:34:48Z', '2018-09-04T08:43:41Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '25.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Boreparameter ', 'Boreparameter er et samlebegrep for verdier som er viktige å overvåke under boring. De vanligste vi overvåker, er framdriften, rate of penetration (ROP), vekten på borekronen, weight on bit (WOB), og friksjonen mot rotasjon på borekronen, torque. Endringer i boreparametrene som ikke er forårsaket av endringer fra borerens kontrollpanel, kan bety at man borer inn i høytrykksone eller får kick inn i brønnen.', 172685, '2018-06-22T15:34:48Z', '2018-09-04T08:43:41Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '24.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Solenoidventil ', 'Solenoidventil er en magnetisk spoleventil som opereres med elektrisk spenning. Når det tilføres spenning, endres den magnetiske retningen i spolen slik at ventilens posisjon endres. Når spenningen fjernes, er det en fjær som bringer ventilen til motsatt posisjon.', 172662, '2018-06-22T15:42:34Z', '2018-09-04T08:43:41Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '24.11.2016', '30.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Solenoidventil ', 'Solenoidventil er en magnetisk spoleventil som opereres med elektrisk spenning. Når det tilføres spenning, endres den magnetiske retningen i spolen slik at ventilens posisjon endres. Når spenningen fjernes, er det en fjær som bringer ventilen til motsatt posisjon.', 172662, '2018-06-22T15:42:34Z', '2018-09-04T08:43:41Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '11.11.2016', '11.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Formasjonsstyrke', 'Den indre kraften i bergarten som må til for å holde massen av bergartene som ligger over. Dypereliggende formasjoner er sterkere enn grunne bergarter på grunn av herdeprosessen som pågår over millioner av år. Når vi drenerer væske ut av porene i bergarten påvirker det den indre styrken slik at bergarten svekkes.', 172158, '2018-06-22T15:35:31Z', '2018-09-04T08:43:30Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '11.11.2016', '11.11.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Formasjonsstyrke', 'Den indre kraften i bergarten som må til for å holde massen av bergartene som ligger over. Dypereliggende formasjoner er sterkere enn grunne bergarter på grunn av herdeprosessen som pågår over millioner av år. Når vi drenerer væske ut av porene i bergarten påvirker det den indre styrken slik at bergarten svekkes.', 172158, '2018-06-22T15:35:31Z', '2018-09-04T08:43:30Z', 'Liv Dagrunn Andreassen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '18.10.2016', '24.10.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Konsolidert bergart', 'En godt konsolidert bergart har en sterk forbindelse eller binding av mineraler mellom sedimentene i bergarten. Bindingene i løse bergarter og avleiringer oppstår ved hjelp av trykkpåvirkning, sammenpressing, omkrystallisering og sementering av sedimentene med nydannede mineraler. Dersom bergarten er løs og faller fra hverandre ved lett belastning, er den dårlig konsolidert.', 171174, '2018-06-22T15:29:01Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '18.10.2016', '24.10.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Konsolidert bergart', 'En godt konsolidert bergart har en sterk forbindelse eller binding av mineraler mellom sedimentene i bergarten. Bindingene i løse bergarter og avleiringer oppstår ved hjelp av trykkpåvirkning, sammenpressing, omkrystallisering og sementering av sedimentene med nydannede mineraler. Dersom bergarten er løs og faller fra hverandre ved lett belastning, er den dårlig konsolidert.', 171174, '2018-06-22T15:29:01Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '15.07.2016', '18.07.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pallebord', 'Pallebord er et bord som kan beveges vertikalt opp og ned. Det brukes til å løfte paller med kjemikalier for mixing av borevæske.', 168492, '2018-06-22T15:32:16Z', '2018-08-17T14:22:27Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '15.07.2016', '18.07.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Pallebord', 'Pallebord er et bord som kan beveges vertikalt opp og ned. Det brukes til å løfte paller med kjemikalier for mixing av borevæske.', 168492, '2018-06-22T15:32:16Z', '2018-08-17T14:22:27Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '18.07.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ppm', 'ppm; parts per million. Måleenhet som vanligvis brukes for konsentrasjon av et stoff i et annet, der små mengder er påviselige og muligens viktige.', 150257, '2018-06-22T15:42:09Z', '2018-09-04T08:43:50Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '18.07.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ppm', 'ppm; parts per million. Måleenhet som vanligvis brukes for konsentrasjon av et stoff i et annet, der små mengder er påviselige og muligens viktige.', 150257, '2018-06-22T15:42:09Z', '2018-09-04T08:43:50Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '04.07.2016', '04.07.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Norsk olje og gass', 'Norsk olje og gass er en interesse- og arbeidsgiverorganisasjon for oljeselskaper og leverandørbedrifter knyttet til utforsking og produksjon av olje og gass på norsk kontinentalsokkel. Norsk olje og gass er en landsforening i NHO, Næringslivets Hovedorganisasjon.', 168316, '2018-06-22T15:45:35Z', '2018-09-04T08:43:53Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '04.07.2016', '04.07.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Norsk olje og gass', 'Norsk olje og gass er en interesse- og arbeidsgiverorganisasjon for oljeselskaper og leverandørbedrifter knyttet til utforsking og produksjon av olje og gass på norsk kontinentalsokkel. Norsk olje og gass er en landsforening i NHO, Næringslivets Hovedorganisasjon.', 168316, '2018-06-22T15:45:35Z', '2018-09-04T08:43:53Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Diskriminering', 'Forskjellsbehandling som får negative konsekvenser for den eller dem det gjelder Direkte diskriminering: når en person blir behandlet dårligere enn en annen på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv. Indirekte diskriminering: når en tilsynelatende nøytral praksis fører til at en person behandles dårligere enn en annen på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv.', 167387, '2018-06-22T14:57:46Z', '2018-08-17T16:09:49Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Diskriminering', 'Forskjellsbehandling som får negative konsekvensar for den eller dei det gjeld Direkte diskriminering: når ein person blir behandla dårlegare enn ein annan på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv. Indirekte diskriminering: når ein tilsynelatande nøytral praksis fører til at ein person blir behandla dårlegare enn ein annan på grunn av kjønn, etnisk bakgrunn, seksuell orientering, funksjonsevne osv.', 167387, '2018-06-22T14:57:46Z', '2018-08-17T16:09:49Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Sosialisering', 'Sosiale prosesser som fører til at individet tilegner seg og tar opp i seg uskrevne og skrevne normer og regler i samfunnet Primærsosialisering: sosialisering i hjemmet og privatsfæren Sekundærsosialisering: sosialisering i det offentlige rommet, for eksempel på skolen eller på fotballaget.', 167349, '2018-06-22T14:57:47Z', '2018-08-17T16:09:52Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Sosialisering', 'Sosiale prosessar som fører til at individet tileignar seg og tek opp i seg uskrivne og skrivne normer og reglar i samfunnet Primærsosialisering: sosialisering i heimen og privatsfæren Sekundærsosialisering: sosialisering i det offentlege rommet, til dømes på skulen eller på fotballaget.', 167349, '2018-06-22T14:57:47Z', '2018-08-17T16:09:52Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Rasisme', 'Å behandle noen mennesker dårligere enn andre på bakgrunn av deres kultur, etnisitet eller religion, og ikke på bakgrunn av deres handlinger.', 167309, '2018-06-22T14:57:45Z', '2018-08-17T16:09:48Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Rasisme', 'Å behandle somme menneske dårlegare enn andre på bakgrunn av kulturen, etnisiteten eller religionen deira, og ikkje på bakgrunn av handlingane deira.', 167309, '2018-06-22T14:57:45Z', '2018-08-17T16:09:48Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Mistillitsforslag', 'Forslag i en nasjonalforsamling om at en minister eller hele regjeringen ikke lenger har nasjonalforsamlingens tillit. Hvis forslaget får flertall i nasjonalforsamlingen, må ministeren eller den sittende regjeringen gå av.', 167284, '2018-06-22T15:04:14Z', '2018-08-20T10:15:09Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Mistillitsforslag', 'Forslag i ei nasjonalforsamling om at ein minister eller heile regjeringa ikkje lenger har tillit i nasjonalforsamlinga. Dersom forslaget får fleirtal i nasjonalforsamlinga, må ministeren eller den sitjande regjeringa gå av.', 167284, '2018-06-22T15:04:14Z', '2018-08-20T10:15:09Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fordom', 'En mening eller oppfatning som vi har gjort oss opp på tross av manglende eller begrenset kunnskap om temaet vi mener noe om.', 167254, '2018-06-22T14:57:46Z', '2018-08-17T16:09:52Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '21.06.2016', '21.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Fordom', 'Ei meining eller oppfatning som vi har gjort oss opp trass i manglande eller avgrensa kunnskap om temaet vi meiner noko om.', 167254, '2018-06-22T14:57:46Z', '2018-08-17T16:09:52Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '20.06.2016', '20.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Generalisering', 'Å generalisere, det vil si å lage allmenne regler basert på sammenlikning av enkelttilfeller. I samfunnsfag er det viktig å studere mange enkelttilfeller for å kunne generalisere.', 167214, '2018-06-22T14:57:00Z', '2018-08-17T17:44:21Z', 'Isak Nordeng Jensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '20.06.2016', '20.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Generalisering', 'Det å generalisere, det vil seie å lage allmenne reglar basert på samanlikning av enkelttilfelle. I samfunnsfag er det viktig å studere mange enkelttilfelle for å kunne generalisere.', 167214, '2018-06-22T14:57:00Z', '2018-08-17T17:44:21Z', 'Isak Nordeng Jensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '20.06.2016', '20.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bærekraftig utvikling', 'Utvikling av samfunnet som ikke går på bekostning av framtidige generasjoners tilgang på ressursene.', 167194, '2018-06-22T15:06:25Z', '2018-08-17T19:12:48Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '20.06.2016', '20.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Berekraftig utvikling', 'Utvikling av samfunnet som ikkje går ut over framtidige generasjonar sin tilgang på ressursane.', 167194, '2018-06-22T15:06:25Z', '2018-08-17T19:12:48Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '20.06.2016', '20.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bakgrunnsvariabel', 'Opplysninger om respondentene, som brukes i tillegg til informasjonen fra hovedspørsmålene når man utfører undersøkelser. Kjønn, alder, bosted og yrke er eksempler på bakgrunnsvariabler.', 167152, '2018-06-22T14:57:01Z', '2018-08-17T17:44:22Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '20.06.2016', '20.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bakgrunnsvariabel', 'Opplysningar om respondentane, som blir brukte i tillegg til informasjonen frå hovudspørsmåla når ein utfører undersøkingar. Kjønn, alder, bustad og yrke er døme på bakgrunnsvariablar.', 167152, '2018-06-22T14:57:01Z', '2018-08-17T17:44:22Z', 'Emily Sørensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '13.06.2016', '16.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Redundancy – overflødighet', 'Redundancy: overflødighet. Å inkludere en ekstra komponent som kan erstatte tapet av en annen uten at drift eller sikkerhet påvirkes. Offshore installeres en ekstra pumpe, et ekstra sikringspanel, et ekstra styringspanel eller annet. Disse har som oppgave å være tilgjengelige (og klar for bruk) om den komponenten som vanligvis er i bruk, feiler.', 166509, '2018-06-22T15:45:28Z', '2018-09-04T08:43:53Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '13.06.2016', '16.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Redundancy - overflødighet', 'Redundancy: overflødighet. Å inkludere en ekstra komponent som kan erstatte tapet av en annen uten at drift eller sikkerhet påvirkes. Offshore installeres en ekstra pumpe, et ekstra sikringspanel, et ekstra styringspanel og så videre. Disse har som oppgave enn å være tilgjengelig (og klar for bruk) om den komponenten som vanligvis er i bruk, feiler.', 166509, '2018-06-22T15:45:28Z', '2018-09-04T08:43:53Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '13.06.2016', '13.06.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Operatør', 'Operatør er et fellesord som beskriver selskapet som er tildelt ansvaret for feltet eller blokken. I Norge er det alltid et oljeselskap (Statoil, ConocoPhillips, Talisman osv.) som er operatørselskapet.', 166414, '2018-06-22T15:45:33Z', '2018-09-04T08:43:53Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        


with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '27.05.2016', '31.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ICD (Inflow control device)', 'ICD (Inflow Control Device). En strupe-mekanisme som brukes for å redusere (regulere) innstrømningen i brønnen på et avgrenset område. Brukes ofte for å forsinke vanngjennombrudd i hælen på lange horisontale brønner. ICD kommer i ulike utgaver fra flere leverandører.', 164692, '2018-06-22T15:40:49Z', '2018-09-04T08:43:36Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '27.05.2016', '31.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ICD (Inflow control device)', 'ICD (Inflow Control Device). En strupe-mekanisme som brukes for å redusere (regulere) innstrømningen i brønnen på et avgrenset område. Brukes ofte for å forsinke vanngjennombrudd i hælen på lange horisontale brønner. ICD kommer i ulike utgaver fra flere leverandører.', 164692, '2018-06-22T15:40:49Z', '2018-09-04T08:43:36Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '27.05.2016', '31.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Svellpakning', 'Svellpakning (swell packer) er et rør med utvendig gummi-element som reagerer med væske (olje eller vann) og sveller i størrelse til det tetter mot den utvendige grensen (brønnen).', 164688, '2018-06-22T15:40:49Z', '2018-09-04T08:43:41Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '27.05.2016', '31.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Svellpakning', 'Svellpakning (swell packer) er et rør med utvendig gummi-element som reagerer med væske (olje eller vann) og sveller i størrelse til det tetter mot den utvendige grensen (brønnen).', 164688, '2018-06-22T15:40:49Z', '2018-09-04T08:43:41Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '27.05.2016', '31.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Sealbore diverter', 'Sealbore diverter. En sealbore er et rørstykke som har en innvendig finpolert overflate. Den brukes som tetningsflate mot utvendige tetninger på rør som stikkes inn i sealboren. En sealbore diverter er skråkuttet i toppen og fungerer som en guide som skråner mot et annet løp i brønnen.', 164686, '2018-06-22T15:40:50Z', '2018-09-04T08:43:44Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '27.05.2016', '31.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Sealbore diverter', 'Sealbore diverter. En sealbore er et rørstykke som har en innvendig finpolert overflate. Den brukes som tetningsflate mot utvendige tetninger på rør som stikkes inn i sealboren. En sealbore diverter er skråkuttet i toppen og fungerer som en guide som skråner mot et annet løp i brønnen.', 164686, '2018-06-22T15:40:50Z', '2018-09-04T08:43:44Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '26.05.2016', '27.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brønnslisse', 'Brønnslisse: En plattform eller havbunnsramme har et begrenset antall åpninger som det kan kobles brønner opp mot. Disse åpningene er på brønnhodedekket og kalles "slots". På norsk brukes uttrykket slisser.', 164645, '2018-06-22T15:40:44Z', '2018-09-04T08:43:37Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '26.05.2016', '27.05.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brønnslisse', 'Brønnslisse: En plattform eller havbunnsramme har et begrenset antall åpninger som det kan kobles brønner opp mot. Disse åpningene er på brønnhodedekket og kalles "slots". På norsk brukes uttrykket slisser.', 164645, '2018-06-22T15:40:44Z', '2018-09-04T08:43:37Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Historie Vg2 og Vg3"}', '03.03.2016', '09.03.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Den fruktbare halvmåne', 'Den fruktbare halvmåne viser til et halvmåneformet område i Midtøsten der tidlig jordbruk og sivilisasjoner utviklet seg, og viktige oppfinnelser som skrift og hjulet kom. Begrepet ble skapt som The Fertile Crescent av den amerikanske arkeologen James Henry Breasted tidlige på 1900-tallet. Området følger elvene Jordan, Eufrat og Tigris fra Levanten ved Middelhavet i vest til Mesopotamia og Persiabukta i øst. Det er avgrenset av det anatoliske høylandet i nord og den syriske ørkenen i sør. I dag ligger statene Irak, Syria, Jordan, Libanon, Israel, De palestinske selvstyreområene og deler av Tyrkia og Iran i området. Man kan også regne Nildalen og Egypt med til området, ettersom også dette var frukbart og folkerikt i oldtida, men jordbruk ble ikke utviklet her. (Kilde: Wikipedia)', 159382, '2018-05-09T14:47:38Z', '2018-09-04T06:27:30Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Historie Vg2 og Vg3"}', '03.03.2016', '09.03.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Den fruktbare halvmåne', 'Den fruktbare halvmånen viser til eit halvbogeforma område i Midtausten der tidleg jordbruk og sivilisasjon utvikla seg, og viktige nyvinngar som skrift og hjulet kom til. Omgrepet blei skapt som The Fertile Crescent av den amerikanske arkeologen James Henry Breasted tidleg på 1900-talet. Området følgjer elvane Jordan, Eufrat og Tigris frå Levanten ved Middelhavet i vest til Mesopotamia og Persiabukta i aust. Det er avgrensa av det anatoliske høglandet i nord og Den syriske ørkenen i sør. I dag ligg statane Irak, Syria, Jordan, Libanon, Israel, Dei palestinske sjølvstyresmaktene og delar av Tyrkia og Iran i området. Ein kan også rekna Nildalen og Egypt med til området, ettersom også dette var fruktsamt og folkesett i oldtida, men jordbruk blei ikkje utvikla her. (Kjelde: Wikipedia)', 159382, '2018-05-09T14:47:38Z', '2018-09-04T06:27:30Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '13.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Lokasjon', 'Fra engelsk location. Lokasjon er det stedet der installasjonen skal ligge over en brønn eller starte brønnboring. Lokasjonen har nøyaktige satellittkoordinater som brukes for å plassere en fast installasjon korrekt på feltet, for å plassere en flytende enhet før ankring, eller som referansepunkter når enheten skal holdes på plass med DP.', 155896, '2018-06-22T15:29:48Z', '2018-08-17T14:22:13Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '13.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Lokasjon', 'Fra engelsk location. Lokasjon er stedet der installasjonen skal ligge over en brønn, eller starte brønnboring. Lokasjon har nøyaktige satellittkoordinater som brukes for å plassere en fast installasjon korrekt på feltet, for å plassere en flytende enhet før ankring, eller som referansepunkter når den skal holdes på plass med DP.', 155896, '2018-06-22T15:29:48Z', '2018-08-17T14:22:13Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '13.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kompensering', 'Kompensere betyr å oppveie, utjevne, erstatte. Når man kompenserer for noe, retter man opp en forandring eller unøyaktighet, eller skaper en balanse. Borestrengskompensering er å lage en bevegelse som virker motsatt av de vertikale bølgebevegelsene, slik at borestrengen blir stående i ro i forhold til borehullet (brønnen).', 155856, '2018-06-22T15:32:09Z', '2018-08-17T14:22:08Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '13.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kompensering', 'Kompensere betyr å oppveie, utjevne, erstatte. Når man kompenserer for noe retter man opp en forandring eller unøyaktighet, eller skaper en balanse. Borestrengskompensering er å lage en bevegelse som virker motsatt av de vertikale bølgebevegelsene, slik at borestrengen blir stående i ro i forhold til borehullet (brønnen).', 155856, '2018-06-22T15:32:09Z', '2018-08-17T14:22:08Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '13.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Thruster', 'Thrustere er spesielle propeller som er innfelt i skroget på den flytende enheten, ofte i siden foran og bak på fartøyet. Kalles ofte sidepropell. Brukes både til posisjonering og framdrift.', 155892, '2018-06-22T15:32:04Z', '2018-08-17T14:22:14Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.01.2016', '13.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Thruster', 'Thrustere er en spesiell propell som er innfelt i skroget på den flytende enheten, ofte i siden foran og bak i fartøyet. Kalles ofte sidepropell. Brukes både til posisjonering og framdrift.', 155892, '2018-06-22T15:32:04Z', '2018-08-17T14:22:14Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Historie Vg2 og Vg3"}', '11.01.2016', '11.01.2016') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Etruskarane', 'Etruskarane er eit folk vi veit relativt lite om. På øya Lemnos i Egeerhavet er det funne ei innskrift frå 600-talet f.Kr., på eit språk som liknar etruskisk. Nokre forskarar tolkar det som at dei hadde innvandra frå aust. Andre meiner Etruskarane var eit urfolk i Toscana. Elles har det berre blitt funne få og korte tekstar på etruskisk, der vi veit tydinga av om lag 100 ord. Det er noko av grunnen til at vi veit så lite om dei. Etruskarane hadde ein blomstringstid då Roma vart grunnlagt, men vart gradvis svekka etter kvart som den nye naboen vaks. Omtrent ved overgangen til romersk keisartid, var heile den etruskiske befolkninga latinisert.', 156327, '2018-05-09T14:49:13Z', '2018-09-04T06:47:26Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '05.08.2011', '10.12.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Framskrivinger', 'Prognoser eller utviklingsforløp i framtiden. Hvordan eksperter mener utviklingen vil gå, f.eks innen innvandring, befolkningsvekst, økonomi o.l.', 83591, '2018-06-22T15:07:07Z', '2018-08-17T17:14:56Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '05.08.2011', '10.12.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Framskrivingar', 'Prognosar eller utviklingsgang i framtida. Korleis ekspertar meiner utviklinga vil gå, til dømes innan innvandring, befolkningsvekst og økonomi.', 83591, '2018-06-22T15:07:07Z', '2018-08-17T17:14:56Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '30.11.2015', '30.11.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Flokkulering', 'Flokkulering beskriver dannelse av en større masse (flokk). Brukes for å beskrive hvordan avlange leirepartikler (f.eks. i bentonittslam) binder seg til hverandre med kortside mot langside, eller langside mot langside. Konsekvensen av slik samling er økt viskositet og økt filtertap.', 153372, '2018-06-22T15:36:02Z', '2018-09-04T08:43:57Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '30.11.2015', '30.11.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Flokkulering', 'Flokkulering beskriver dannelse av en større masse (flokk). Brukes for å beskrive hvordan avlange leirepartikler (f.eks. i bentonittslam) binder seg til hverandre med kortside mot langside, eller langside mot langside. Konsekvensen av slik samling er økt viskositet og økt filtertap.', 153372, '2018-06-22T15:36:02Z', '2018-09-04T08:43:57Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '28.10.2015', '04.11.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Filterkake', 'Filterkake dannes på overflaten av et filter når partikler fra en væske stoppes, mens væsken passerer gjennom filteret. Når filterkaken er tett, vil den hindre væske fra å strømme gjennom filteret. Filterkake i brønnen hindrer tap av borevæske inn i formasjonen.', 151694, '2018-06-22T15:35:53Z', '2018-09-04T08:43:34Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '28.10.2015', '04.11.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Filterkake', 'Filterkake dannes på overflaten av et filter når partikler fra en væske stoppes, mens væsken passerer gjennom filteret. Når filterkaken er tett, vil den hindre væske fra å strømme gjennom filteret. Filterkake i brønnen hindrer tap av borevæske inn i formasjonen.', 151694, '2018-06-22T15:35:53Z', '2018-09-04T08:43:34Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '28.10.2015', '04.11.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Filtrat', 'Filtrat er filtrert væske, der partikler og forurensninger blir holdt tilbake på et filter, mens væsken (filtratet) går gjennom filteret. Filtrat i forbindelse med borevæske er væsken som klarer å trenge inn i formasjonens porer, mens partiklene stopper på overflaten av formasjonen og danner filterkake.', 151693, '2018-06-22T15:35:52Z', '2018-09-04T08:43:37Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '28.10.2015', '04.11.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Filtrat', 'Filtrat er filtrert væske, der partikler og forurensninger blir holdt tilbake på et filter, mens væsken (filtratet) går gjennom filteret. Filtrat i forbindelse med borevæske er væsken som klarer å trenge inn i formasjonens porer, partiklene stopper på overflaten av formasjonen og danner filterkake.', 151693, '2018-06-22T15:35:52Z', '2018-09-04T08:43:37Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '18.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Entringsvakt', 'Entringsvakt: Passer på personen(e) som har entret et risiko-område eller tank. Skal ha kontinuerlig kontakt med de som overvåkes.', 148658, '2018-06-22T15:46:15Z', '2018-09-04T08:43:53Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '18.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Entringsvakt', 'Entringsvakt: Passer på personen(e) som har entret et risiko-område eller tank. Skal ha kontinuerlig kontakt med de som overvåkes.', 148658, '2018-06-22T15:46:15Z', '2018-09-04T08:43:53Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '18.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brannvakt', 'En brannvakt skal være tilstede på arbeidsstedet og kontrollere for eventuelle branntilløp. Brannvakten har opplæring i sine oppgaver og skal være merket med vest eller lignende. Brannvakten skal være kjent med SJA.', 148674, '2018-06-22T15:46:10Z', '2018-09-04T08:43:57Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '18.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brannvakt', 'En brannvakt skal være tilstede på arbeidsstedet og kontrollere for eventuelle branntilløp. Brannvakten har opplæring i sine oppgaver og skal være merket med vest eller lignende. Brannvakten skal være kjent med SJA.', 148674, '2018-06-22T15:46:10Z', '2018-09-04T08:43:57Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '17.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Dobbel sikring', 'Dobbel sikring vil si at utstyr er sikret med to uavhengige sikringer.', 148607, '2018-06-22T15:46:02Z', '2018-09-04T08:43:55Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '17.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Dobbel sikring', 'Dobbel sikring vil si at utstyr er sikret med to uavhengige sikringer.', 148607, '2018-06-22T15:46:02Z', '2018-09-04T08:43:55Z', 'Yttervik Reinholdtsen Lisbeth', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '20.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Barriere', 'Barriere; skal hindre eller redusere risiko for feil, fare eller ulykke. Det finnes tekniske, operasjonelle og organisatoriske barrierer. Eksempel fra hverdagen: et rekkverk på en trapp er en teknisk barriere mot fall sideveis ut av trappen, dersom brukere av trappen holder i rekkverket kan det også forhindre et fall i trappen.', 148778, '2018-06-22T15:41:39Z', '2018-09-04T08:43:52Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '20.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Barriere', 'Barriere; skal hindre eller redusere risiko for feil, fare eller ulykke. Det finnes tekniske, operasjonelle og organisatoriske barrierer. Eksempel fra hverdagen: et rekkverk på en trapp er en teknisk barriere mot fall sideveis ut av trappen, dersom brukere av trappen holder i rekkverket kan det også forhindre et fall i trappen.', 148778, '2018-06-22T15:41:39Z', '2018-09-04T08:43:52Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '18.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Driller', 'Driller / borer: Boreren er utførende og ansvarlig for aktivitetene i bore- og brønnoperasjonen. Sitter i driller-bua og styrer boreutstyret.', 148684, '2018-06-22T15:46:03Z', '2018-09-04T08:43:52Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '18.08.2015', '05.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Driller', 'Driller / borer: Boreren er utførende og ansvarlig for aktivitetene i bore- og brønnoperasjonen. Sitter i driller-bua og styrer boreutstyret.', 148684, '2018-06-22T15:46:03Z', '2018-09-04T08:43:52Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '01.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Flottør ', 'Flottør er en lufttett kolbe som flyter på væske. Den er hengslet til en ventil som åpner/lukker når flottøren kommer til et forhåndsbestemt nivå.', 150232, '2018-06-22T15:41:59Z', '2018-09-04T08:43:42Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '01.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Flottør ', 'Flottør er en lufttett kolbe som flyter på væske. Den er hengslet til en ventil som åpner/lukker når flottøren kommer til et forhåndsbestemt nivå.', 150232, '2018-06-22T15:41:59Z', '2018-09-04T08:43:42Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '01.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brønnhodetrykk', 'Brønnhodetrykk er trykket som den produserte væsken/gassen har når den er kommet opp til brønnhodet i toppen av brønnen. På engelsk: wellhead pressure. Det opprinnelige trykket i reservoaret reduseres opp til brønnhodet på grunn av friksjon og hydrostatisk mottrykk i produksjonsrøret.', 150242, '2018-06-22T15:38:59Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '25.09.2015', '01.10.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Brønnhodetrykk', 'Brønnhodetrykk er trykket som den produserte væsken/gassen har når den har kommet opp til brønnhodet i toppen av brønnen. På engelsk: wellhead pressure. Det opprinnelige trykket i reservoaret reduseres opp til brønnhodet på grunn av friksjon og hydrostatisk mottrykk i produksjonsrøret.', 150242, '2018-06-22T15:38:59Z', '2018-09-04T08:43:58Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kunstig diamant', 'Kunstig diamant kalles ofte industriell diamant. Den lages ved høyt trykk og varme av rent karbon. Diamanten som skapes er ikke av smykkekvalitet eller -størrelse, men har tilnærmet den naturlige diamantens hardhet og fungerer derfor utmerket som kutteverktøy.', 149590, '2018-06-22T15:34:16Z', '2018-09-04T08:43:31Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kunstig diamant', 'Kunstig diamant kalles ofte industriell diamant. Den lages ved høyt trykk og varme av rent karbon. Diamanten som skapes er ikke av smykkekvalitet eller -størrelse men har tilnærmet den naturlige diamantens hardhet og fungerer derfor utmerket som kutteverktøy.', 149590, '2018-06-22T15:34:16Z', '2018-09-04T08:43:31Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Konus', 'Konus er en geometrisk form bestående av en sylinder med en bred og en smal ende. Eksempel på kon-form kan være melkeglass, vaskebøtte, lampeskjerm osv. Konisiteten er et forholdstall mellom den brede enden og den smale enden.', 149589, '2018-06-22T15:34:17Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Konus', 'Konus er en geometrisk form bestående av en sylinder med en bred og en smal ende. Eksempel på kon-form kan være melkeglass, vaskebøtte, lampeskjerm osv. Konisiteten er et forholdstall mellom den brede enden og den smale enden.', 149589, '2018-06-22T15:34:17Z', '2018-09-04T08:43:36Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('wolframkarbid', 'Wolframkarbid (WC) er et svært hardt metallglinsende stoff som brukes i stedet for diamanter på slipeverktøy og borekroner. Det er stabilt opp til 2800 °C, nesten like hardt som diamant, og fremstilles ved at man lar wolfram reagere med karbon ved høy temperatur.', 149587, '2018-06-22T15:34:18Z', '2018-09-04T08:43:38Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('wolframkarbid', 'Wolframkarbid (WC) er et svært hardt metallglinsende stoff som brukes i stedet for diamanter på slipeverktøy og borekroner. Det er stabilt opp til 2800 °C, nesten like hardt som diamant, og fremstilles ved at man lar wolfram reagere med karbon ved høy temperatur.', 149587, '2018-06-22T15:34:18Z', '2018-09-04T08:43:38Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Droppe vinkel', 'Å droppe vinkel i en brønn betyr å redusere vinkelen ned mot 0° (vertikal).', 149579, '2018-06-22T15:34:11Z', '2018-09-04T08:43:33Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '14.09.2015', '17.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Droppe vinkel', 'Droppe vinkel i en brønn betyr å redusere vinkelen ned mot 0° (vertikal).', 149579, '2018-06-22T15:34:11Z', '2018-09-04T08:43:33Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '04.09.2015', '07.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Setback', 'Setback (engelsk); det området som er reservert til plassering av borerør som er skrudd sammen i stands. Setback er på boredekk i et konvensjonelt boretårn og lavere plassert på ramrigg.', 149254, '2018-06-22T15:46:39Z', '2018-09-04T08:43:51Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '04.09.2015', '07.09.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Setback', 'Setback (engelsk); det området som er reservert til plassering av borerør som er skrudd sammen i stands. Setback er på boredekk i et konvensjonelt boretårn og lavere plassert på ramrigg.', 149254, '2018-06-22T15:46:39Z', '2018-09-04T08:43:51Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '19.08.2015', '28.08.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('EX-beskyttelse', 'EX-beskyttelse; Elektrisk utstyr som er sikret slik at det ikke bidrar til antenning av brennbare eller eksplosive materialer på grunn av gnistdannelse. Ex-beskyttelsen kan være innpakning/isolasjon eller plassering av utstyret i overtrykkskammer slik at det ytre miljø ikke når inn til det elektriske utstyret.', 148723, '2018-06-22T15:46:09Z', '2018-09-04T08:43:50Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '19.08.2015', '28.08.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('EX-beskyttelse', 'EX-beskyttelse; Elektrisk utstyr som er sikret slik at det ikke bidrar til antenning av brennbare eller eksplosive materialer på grunn av gnistdannelse. Ex-beskyttelsen kan være innpakning/isolasjon eller plassering av utstyret i overtrykkskammer slik at det ytre miljø ikke når inn til det elektriske utstyret.', 148723, '2018-06-22T15:46:09Z', '2018-09-04T08:43:50Z', 'Sissel Paaske', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '05.08.2015', '05.08.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Korrosjon', 'Korrosjon; tæring på materialer ved kjemiske eller elektrokjemiske reaksjoner med omgivelsene. Begrepet brukes særlig i forbindelse med metaller og legeringer.', 148146, '2018-06-22T15:43:15Z', '2018-09-04T08:44:18Z', 'Stine Frivåg', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '05.08.2015', '05.08.2015') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Korrosjon', 'Korrosjon; tæring på materialer ved kjemiske eller elektrokjemiske reaksjoner med omgivelsene. Begrepet brukes særlig i forbindelse med metaller og legeringer.', 148146, '2018-06-22T15:43:15Z', '2018-09-04T08:44:18Z', 'Stine Frivåg', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Br\u00f8nnteknikk"}', '06.10.2014', '07.10.2014') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('75''', '75’ = 75 fot = 2286 cm = 22,9 m', 137721, '2018-06-22T15:30:00Z', '2018-08-17T14:21:42Z', 'Stine Frivåg', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Br\u00f8nnteknikk"}', '06.10.2014', '07.10.2014') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('75''', '75’ = 75 fot = 2286 cm = 22,9 m', 137721, '2018-06-22T15:30:00Z', '2018-08-17T14:21:42Z', 'Stine Frivåg', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Transport og logistikk Vg2"}', '09.01.2013', '21.01.2013') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Primærnæringane', 'jordbruk, skogbruk, fiske, fangst og utvinning', 111917, '2018-06-22T15:06:53Z', '2018-08-17T19:20:24Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Transport og logistikk Vg2"}', '09.01.2013', '21.01.2013') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Primærnæringene', 'jordbruk, skogbruk, fiske, fangst og utvinning', 111917, '2018-06-22T15:06:53Z', '2018-08-17T19:20:24Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": "Spr\u00e5kn\u00f8ytral", "subject": "Medie- og informasjonskunnskap 1 og 2"}', '25.06.2012', '25.06.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Cliffhanger', 'Cliffhanger: fortellermessig grep i film, stammer fra stumfilmtidens seriefilmer. Disse ble vist på kino avsnitt for avsnitt, og for å lokke publikum til neste avsnitt kunne man avslutte med en scene hvor hovedpersonen var i en farlig situasjon uten utveier, f.eks. presset av overtallige skurker, kastet i bjørnegården, plassert bundet på en jernbanelinje – eller etterlatt hengende fra en fjellhylle, derav navnet. Neste avsnitt måtte da innledes med heltens mirakuløse redning. Slike spenningsskapende grep har også vært benyttet i fjernsynsserier, og begrepet er dessuten blitt tatt i bruk i litteraturen. I Store norske leksikon. Hentet fra: http://snl.no/cliffhanger', 100722, '2018-05-04T21:19:38Z', '2018-05-27T21:10:40Z', 'Ragna Tørdal', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '03.02.2012', '03.02.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kvalifikasjon', 'Kvalifikasjon: ei utdanning eller opplæring som gjer deg skikka til å utføre ei bestemt oppgåve', 95160, '2018-05-04T20:42:36Z', '2018-09-04T06:19:56Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '03.02.2012', '03.02.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Kvalifikasjon', 'Kvalifikasjon: en utdanning eller opplæring som gjør deg egnet til å utføre en bestemt oppgave.', 95160, '2018-05-04T20:42:36Z', '2018-09-04T06:19:56Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Service og samferdsel Vg1"}', '03.02.2012', '03.02.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Hierarki', 'Hierarki: ei rangordning der dei som står øvst, har meir ansvar og styringsrett enn dei lenger ned i hierarkiet', 95159, '2018-05-04T20:42:35Z', '2018-09-04T06:19:54Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Service og samferdsel Vg1"}', '03.02.2012', '03.02.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Hierarki', 'Hierarki: en rangordning der de som er øverst, har mer ansvar og myndighet enn de lenger nede i hierarkiet', 95159, '2018-05-04T20:42:35Z', '2018-09-04T06:19:54Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": "Spr\u00e5kn\u00f8ytral", "subject": "Service og samferdsel Vg1"}', '19.12.2011', '09.01.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Revisor ', 'Revisor er en person som kontrollerer regnskapet på vegne av myndighetene.', 92403, '2018-05-04T21:04:59Z', '2018-09-04T08:44:45Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": "Spr\u00e5kn\u00f8ytral"}', '04.01.2012', '09.01.2012') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Revisor', 'Revisor er ein person som kontrollerer rekneskapen på vegner av styresmaktene.', 92832, '2018-05-27T22:40:54Z', '2018-09-04T08:44:48Z', 'Eidnes Trond', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": "Spr\u00e5kn\u00f8ytral", "subject": "Service og samferdsel Vg1"}', '16.12.2011', '16.12.2011') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Friksjon', 'Friksjon er gnidingsmotstand.', 92354, '2018-06-18T08:31:16Z', '2018-06-22T16:50:27Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": "Spr\u00e5kn\u00f8ytral", "subject": "Service og samferdsel Vg1"}', '16.12.2011', '16.12.2011') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Integrere', 'Å integrere er å innlemme som del av eller å innpasse i eit heile.', 92353, '2018-06-18T08:31:11Z', '2018-06-22T16:50:24Z', 'amendor', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '18.03.2009', '04.10.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('representativt/indirekte demokrati', 'I eit representativt demokrati vel innbyggjarane representantar som styrer på vegner av dei. Denne styreforma blir også kalla indirekte demokrati.', 6869, '2018-06-22T15:03:51Z', '2018-08-20T10:17:00Z', 'Gro-Anita Mortensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '18.03.2009', '04.10.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('representativt/indirekte demokrati', 'I et representativt demokrati velger innbyggerne representanter som styrer på vegne av dem. Denne styreformen kalles også indirekte demokrati.', 6869, '2018-06-22T15:03:51Z', '2018-08-20T10:17:00Z', 'Gro-Anita Mortensen', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Samfunnsfag"}', '10.02.2010', '29.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ILO', 'ILO står for International Labour Organization – den internasjonale arbeidarorganisasjonen. Det er ein av organisasjonane i FN-systemet.', 50202, '2018-06-22T15:14:49Z', '2018-08-20T09:58:40Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Samfunnsfag"}', '10.02.2010', '29.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('ILO', 'ILO står for International Labour Organization – den internasjonale arbeiderorganisasjonen. Den er en av organisasjonene i FN-systemet.', 50202, '2018-06-22T15:14:49Z', '2018-08-20T09:58:40Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '04.05.2009', '28.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Trontaledebatten', 'Trontaledebatten er ein debatt om den årlege trontalen. Trontalen blir lesen opp av Kongen ved den høgtidelege opninga av Stortinget og inneheld regjeringas programerklæring for året som kjem.', 11288, '2018-06-22T15:02:29Z', '2018-08-20T10:16:46Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '04.05.2009', '28.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Trontaledebatten', 'Trontaledebatten er en debatt om den årlige trontalen. Trontalen leses opp av Kongen ved Stortingets høytidelige åpning og inneholder regjeringens programerklæring for kommende år.', 11288, '2018-06-22T15:02:29Z', '2018-08-20T10:16:46Z', '', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Digital kompetanse"}', '11.01.2010', '26.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bygg opp-strategi', 'Ein strategi for problemløysing som startar med primitivane. Strategien kan vere målretta, slik at primitivar blir sette saman til ein heilskap med eit bestemt mål i sikte. Strategien kan også brukast på ein meir tilfeldig måte, utan eit klart mål i sikte. Målet kan formast etter kvart som du løyser fleire av primitivane.', 48020, '2018-05-04T14:59:12Z', '2018-05-04T15:00:04Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Digital kompetanse"}', '11.01.2010', '26.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bygg opp-strategi', 'En strategi for problemløsing som starter med primitivene. Strategien kan være målrettet, slik at primitiver settes sammen til en helhet med et bestemt mål i sikte. Strategien kan også brukes på en mer tilfeldig måte, uten et klart mål i sikte. Målet kan formes etter hvert som du løser flere av primitivene.', 48020, '2018-05-04T14:59:12Z', '2018-05-04T15:00:04Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Høgnivåspråk', 'Eit programmeringsspråk som til dømes BASIC, COBOL, Logo, Java, C++, C# eller PHP. Alle kodelinjer i språket blir omsette av datamaskina til maskinspråk. Høgnivåspråk er lettare å forstå enn maskinspråk, fordi det liknar meir på vårt eige talespråk enn maskinspråk gjer.', 48072, '2018-05-04T14:09:59Z', '2018-05-04T15:00:02Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Høynivåspråk', 'Et programmeringsspråk som for eksempel BASIC, COBOL, Logo, Java, C++, C# eller PHP. Alle kodelinjer i språket oversettes av datamaskinen til maskinspråk. Høynivåspråk er lettere å forstå enn maskinspråk, fordi det ligner mer på vårt eget talespråk enn maskinspråk gjør.', 48072, '2018-05-04T14:09:59Z', '2018-05-04T15:00:02Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Debug', 'Å fjerne feil frå dataprogram ved å analysere den overordna prosessen for å løyse eit problem.', 48037, '2018-05-04T14:09:59Z', '2018-05-04T15:00:03Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Debug', 'Å fjerne feil fra dataprogrammer ved å analysere den overordnede prosessen for å løse et problem.', 48037, '2018-05-04T14:09:59Z', '2018-05-04T15:00:03Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bug', 'Ein feil eller ei misforståing. Ein bug i eit dataprogram kan komme av ein feil i planen for å lage programmet. Det kan òg vere ein feil eller ei misforståing i prosedyren som blir programmert.', 48019, '2018-05-04T14:10:00Z', '2018-05-04T15:00:03Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Bug', 'En feil eller en misforståelse. En bug i et dataprogram kan skyldes en feil i planen for å lage programmet. Det kan også være en feil eller misforståelse i prosedyren som programmeres.', 48019, '2018-05-04T14:10:00Z', '2018-05-04T15:00:03Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Maskinspråk', 'Kvar datamaskin er laga for å ”forstå”. Det betyr at datamaskina må vere i stand til å utføre ei avgrensa mengd handlingar og operasjonar. Slike operasjonar, eller primitivar, kallar vi maskinspråk. Ulike merke og modellar har forskjellig maskinspråk.', 48094, '2018-05-04T14:10:00Z', '2018-05-04T15:00:04Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"], "subject": "Digital kompetanse"}', '11.01.2010', '25.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Maskinspråk', 'Hver datamaskin er laget for å ”forstå”. Det betyr at datamaskinen må være i stand til å utføre et begrenset antall handlinger og operasjoner. Slike operasjoner, eller primitiver, kalles maskinspråk. Ulike merker og modeller har forskjellig maskinspråk.', 48094, '2018-05-04T14:10:00Z', '2018-05-04T15:00:04Z', 'Sigurd Alnæs', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nn", "Nynorsk"]}', '15.09.2010', '22.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('FN-pakta', 'FN-pakta er den avtalen som etablerte organisasjonen Dei sameinte nasjonane (FN).', 60708, '2018-05-09T15:44:53Z', '2018-09-04T06:47:08Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": ["nb", "Bokm\u00e5l"]}', '15.09.2010', '22.09.2010') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('FN-pakten', 'FN-pakten er den avtalen som etablerte organisasjonen De forente nasjoner (FN).', 60708, '2018-05-09T15:44:53Z', '2018-09-04T06:47:08Z', 'Inga Berntsen Rudi', (select "id" from meta));
        
        

with meta as (
    INSERT INTO public."concept_metas"("data", "created", "modified")
    VALUES('{"language": "Spr\u00e5kn\u00f8ytral"}', '04.05.2009', '04.05.2009') returning *
)
INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author", "metadataId")
VALUES('Ad-hoc aksjon', 'Ad-hoc aksjon er en aksjonsform som er tidsavgrenset og gjelder bare en sak.', 11325, '2018-06-22T15:03:16Z', '2018-08-20T10:11:28Z', '', (select "id" from meta));
        
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Bryt ned-strategi', 'En strategi for å bryte ned problemer i mindre problemer. Målet er å finne alle primitivene og arbeide med disse. Se Primitiv. Når alle primitivene er løst og løsningene er smeltet sammen på en hensiktsmessig måte, er det opprinnelige overordnede problemet løst.', 48018, '2018-05-04T14:59:12Z', '2018-05-04T15:00:04Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Bryt ned-strategi', 'Ein strategi for å bryte ned problem i mindre problem. Målet er å finne alle primitivane og arbeide med dei. Sjå Primitiv. Når alle primitivane er løyste og løysingane er smelta saman på ein føremålstenleg måte, er det opphavlege overordna problemet løyst.', 48018, '2018-05-04T14:59:12Z', '2018-05-04T15:00:04Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Varsling', 'Varsling er å gå videre med kritikkverdige forhold til noen som kan gjøre noe med det. Kritikkverdige forhold er brudd på lover og regler, brudd på interne regler eller brudd på etiske normer.', 187383, '2018-05-27T22:37:00Z', '2018-09-04T06:20:57Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Varsling', 'Varsling er å gå vidare med kritikkverdige forhold til nokon som kan gjere noko med det. Kritikkverdige forhold er brot på lover og reglar, brot på interne reglar eller brot på etiske normer.', 187383, '2018-05-27T22:37:00Z', '2018-09-04T06:20:57Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Familie und Beruf miteinander verbinden', 'kombinere familie og yrke', 172519, '2018-05-04T20:13:28Z', '2018-09-04T06:24:31Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Familie und Beruf miteinander verbinden', 'kombinere familie og yrke', 172519, '2018-05-04T20:13:28Z', '2018-09-04T06:24:31Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Zur Generation Z zählen die Forscher ', 'Til generasjon Z regner forskerne / reknar forskarane', 172514, '2018-05-04T20:13:29Z', '2018-09-04T06:24:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Zur Generation Z zählen die Forscher ', 'Til generasjon Z reknar forskarane / regner forskerne', 172514, '2018-05-04T20:13:29Z', '2018-09-04T06:24:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('partnerschaftlicher als früher', 'mer likeverdig enn tidligere / meir likeverdig enn tidlegare', 172499, '2018-05-04T20:13:30Z', '2018-09-04T06:24:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('partnerschaftlicher als früher', 'meir likeverdig enn tidlegare / mer likeverdig enn tidligere', 172499, '2018-05-04T20:13:30Z', '2018-09-04T06:24:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Sharing-Mentalität', 'positiv holdning / haldning til deling', 172520, '2018-05-04T20:13:27Z', '2018-09-04T06:24:29Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Sharing-Mentalität', 'positiv haldning / holdning til deling', 172520, '2018-05-04T20:13:27Z', '2018-09-04T06:24:29Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('ganz oben auf der Rangordnung', 'helt øverst / heilt øvst på lista', 172521, '2018-05-04T20:13:27Z', '2018-09-04T06:24:28Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('ganz oben auf der Rangordnung', 'heilt øvst / helt øverst på lista', 172521, '2018-05-04T20:13:27Z', '2018-09-04T06:24:28Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('sturen Hierarchien', 'strenge rangordninger / rangordningar', 172517, '2018-05-04T20:13:28Z', '2018-09-04T06:24:30Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('sturen Hierarchien', 'strenge rangordningar / rangordninger', 172517, '2018-05-04T20:13:28Z', '2018-09-04T06:24:30Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('dass sich Firmen bei jungen Mitarbeitern bewerben', 'at bedrifter "søker jobb" hos unge medarbeidere / medarbeidarar', 172515, '2018-05-04T20:13:29Z', '2018-09-04T06:24:32Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('dass sich Firmen bei jungen Mitarbeitern bewerben', 'at bedrifter "søker jobb" hos unge medarbeidarar / medarbeidere', 172515, '2018-05-04T20:13:29Z', '2018-09-04T06:24:32Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('wenn das Smartphone ausfällt', 'når smartphonen svikter / sviktar', 172513, '2018-05-04T20:13:29Z', '2018-09-04T06:24:34Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('wenn das Smartphone ausfällt', 'når smartphonen sviktar / svikter', 172513, '2018-05-04T20:13:29Z', '2018-09-04T06:24:34Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('von 1985 bis 2000 geborenen', 'født / fødde mellom 1985 og 2000', 172512, '2018-05-04T20:13:30Z', '2018-09-04T06:24:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('von 1985 bis 2000 geborenen', 'fødde / født mellom 1985 og 2000', 172512, '2018-05-04T20:13:30Z', '2018-09-04T06:24:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('nicht unbedingt', 'ikke / ikkje nødvendigvis', 172510, '2018-05-04T20:13:30Z', '2018-09-04T06:24:37Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('nicht unbedingt', 'ikkje / ikke nødvendigvis', 172510, '2018-05-04T20:13:30Z', '2018-09-04T06:24:37Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('angepasst', 'veltilpassa', 172496, '2018-05-04T20:13:25Z', '2018-09-04T06:24:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('angepasst', 'veltilpassa', 172496, '2018-05-04T20:13:25Z', '2018-09-04T06:24:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Friksjon', 'Friksjon er gnidningsmotstand.', 89223, '2018-05-04T20:57:01Z', '2018-08-20T08:35:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Friksjon', 'Friksjon er gnidningsmotstand.', 89223, '2018-05-04T20:57:01Z', '2018-08-20T08:35:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Friksjon', 'Friksjon er gnidingsmotstand.', 89223, '2018-05-04T20:57:01Z', '2018-08-20T08:35:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Allel', 'Genutgave, alternativ utgave av et gen. Alle individer har to allel for hvert gen. Det ene allelet er nedarvet fra far og det andre fra mor. Eksempel: Det finnes allel for blå og brun øyenfarge. Det brune dominerer over det blå, så dersom du har blå øyne kan du være sikker på at du har to allel med kode for blå øyne.', 9104, '2018-05-27T23:41:29Z', '2018-06-11T09:17:58Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Allel', 'Genutgåve, alternativ utgåve av eit gen. Alle individ har to allel for kvart gen. Det eine allelet er nedarva frå far og det andre frå mor. Eksempel: Det finnast allel for blå og brun augefarge. Det brune dominerer over det blå, så dersom du har blå auge kan du være viss på at du har to allel med kode for blå auge.', 9104, '2018-05-27T23:41:29Z', '2018-06-11T09:17:58Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Taifa', 'En taifa var i realiteten en bystat med kontroll av landdistriktene omkring. De mange små taifa-kongedømmene ble etter hvert erobret av de større. Rundt 1050 fantes det seks store, Badajoz, Toledo, Valencia, Granada, Zaragoza og Sevilla.', 182749, '2018-05-09T14:55:48Z', '2018-09-04T06:45:37Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Taifa', 'Ein taifa var i realiteten ein bystat med kontroll av landdistrikta ikring. Dei mange små taifa-kongedømma vart etter kvart erobra av dei større. Rundt 1050 fanst det seks store, Badajoz, Toledo, Valencia, Granada, Zaragoza og Sevilla.', 182749, '2018-05-09T14:55:48Z', '2018-09-04T06:45:37Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Morisker', 'Morisker (liten maurer). Betegnelsen på de spanske muslimene (og deres etterkommere) som hadde latt seg døpe etter erobringen av Granada i 1492.', 182735, '2018-05-09T14:55:20Z', '2018-09-04T06:49:00Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Moriskar', 'Moriskar (liten maurar). Nemninga på dei spanske muslimane (og etterkomarane deira) som hadde latt seg døype etter erobringa av Granada i 1492.', 182735, '2018-05-09T14:55:20Z', '2018-09-04T06:49:00Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Separatfred', 'Russland og Tyskland inngikk fredsavtalen uten å involvere alliansepartnerne sine.', 185059, '2018-05-09T15:35:35Z', '2018-09-04T08:03:22Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Separatfred', 'Russland og Tyskland inngjekk fredsavtalen utan å involvere alliansepartnarane sine.', 185059, '2018-05-09T15:35:35Z', '2018-09-04T08:03:22Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Faststoffinnhold ', 'Faststoffinnhold beskriver innholdet av partikler som ikke løser seg i syre eller væske. Partiklene er tilsatt borevæske for å bidra til å tette porer i formasjonen slik at ikke væske fra borevæsken lekker ut i formasjonen fra brønnen som bores.', 153314, '2018-06-22T15:35:21Z', '2018-09-04T08:43:32Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Faststoffinnhold ', 'Faststoffinnhold beskriver innholdet av partikler som ikke løser seg i syre eller væske. Partiklene er tilsatt borevæske for å bidra til å tette porer i formasjonen slik at ikke væske fra borevæsken lekker ut i formasjonen fra brønnen som bores.', 153314, '2018-06-22T15:35:21Z', '2018-09-04T08:43:32Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Nøytralpunkt', 'Borestrengens nøytralpunkt er der strengen hverken har strekk- eller kompresjonskrefter. Nøytralpunktets plassering kan beregnes ved å ta hensyn til vekt på borestrengen, vekt som settes ned på borekronen, oppdrift i borevæsken og vinkel på brønnen.', 162797, '2018-06-22T15:33:51Z', '2018-09-04T06:39:30Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Nøytralpunkt', 'Borestrengens nøytralpunkt er der strengen hverken har strekk- eller kompresjonskrefter. Nøytralpunktets plassering kan beregnes ved å ta hensyn til vekt på borestrengen, vekt som settes ned på borekronen, oppdrift i borevæsken og vinkel på brønnen.', 162797, '2018-06-22T15:33:51Z', '2018-09-04T06:39:30Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Tungtvann', 'Tungtvann: deuteriumoksid, D2O, en vannklar væske uten lukt og smak som blant annet brukes i kjernereaktorer. De allierte fryktet at nazistene skulle bruke tungtvannet til å utvikle en atombombe.', 185394, '2018-05-09T15:49:16Z', '2018-09-04T06:48:59Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Tungtvatn', 'Tungtvatn: deuteriumoksid, D2O, ei vassklar væske utan lukt og smak som mellom anna blir brukt i kjernereaktorar. Dei allierte frykta at nazistane skulle bruke tungtvatnet til å utvikle ei atombombe.', 185394, '2018-05-09T15:49:16Z', '2018-09-04T06:48:59Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Koeffisient', 'Koeffisient er en konstant størrelse som skal multipliseres med andre størrelser for å beregne egenskaper. Konstanten kan brukes for ulike material- eller systemegenskaper: friksjonskoeffisienten, utvidelseskoeffisienten og så videre.', 148141, '2018-06-22T15:36:55Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Koeffisient', 'Koeffisient er en konstant størrelse som skal multipliseres med andre størrelser for å beregne egenskaper. Konstanten kan brukes for ulike material- eller systemegenskaper: friksjonskoeffisienten, utvidelseskoeffisienten og så videre.', 148141, '2018-06-22T15:36:55Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kassekreditt', 'Med kassekreditt kan bedriften overtrekke sin driftskonto inntil en avtalt kredittramme hos banken sin.', 187648, '2018-05-27T22:40:08Z', '2018-09-04T08:45:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kassekreditt', 'Med kassekreditt kan bedrifta overtrekkje driftskontoen sin inntil ei avtalt kredittramme hos banken sin.', 187648, '2018-05-27T22:40:08Z', '2018-09-04T08:45:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Hercules `søyler', 'Hercules `søyler er et område i dag kjent som Gibraltar i nord og fjellene i Marokko. Navnet Gibraltar er utledet fra det arabiske Tariqs fjell, etter hærføreren Tariq ibn Ziyad som ledet en berberdominert hær over stredet fra Ceuta i 711.', 182746, '2018-05-09T14:55:38Z', '2018-09-04T06:45:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Herculus'' søyler', 'Heculus'' søyler er eit område i dag kjent som Gibraltar i nord og fjella i Marokko. Namnet Gibraltar er utleidd frå det arabiske Tariqs fjell, etter hærføraren Tariq ibn Ziyad som leidde ein berbardominert hær over stretet frå Ceuta i 711.', 182746, '2018-05-09T14:55:38Z', '2018-09-04T06:45:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('mistillitsforslag', 'Mistillitsforslag kan fremmes for Stortinget av en eller flere stortingsrepresentanter. Dersom det blir vedtatt, innebærer det et mistillitsvotum. Det er en uttalelse som uttrykker at stortingsflertallet ikke har tillit til regjeringen eller til en enkelt statsråd. Regjeringen eller statsråden tvinges dermed til å gå av.', 11254, '2018-05-09T15:17:35Z', '2018-09-04T08:51:49Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('mistillitsforslag', 'Mistillitsforslag kan fremjast for Stortinget av ein eller fleire stortingsrepresentantar. Dersom det blir vedteke, inneber det eit mistillitsvotum. Det er ei ytring som uttrykkjer at stortingsfleirtalet ikkje har tillit til regjeringa eller til ein einskild statsråd. Regjeringa eller statsråden blir med det tvinga til å gå av.', 11254, '2018-05-09T15:17:35Z', '2018-09-04T08:51:49Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Bruttonasjonalprodukt (BNP)', 'Bruttonasjonalproduktet (BNP) viser verdien av alt som skapes/produseres i et land. BNP omfatter verdiskapingen i all markedsrettet næringsvirksomhet, dessuten offentlig forvaltning, ideelle organisasjoner og produksjon for eget bruk. BNP per innbygger brukes ofte som et mål på velstandsnivået i et land. SSB', 1798, '2018-05-09T15:56:08Z', '2018-09-04T08:31:26Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Bruttonasjonalprodukt (BNP)', 'Bruttonasjonalproduktet (BNP) syner verdien av alt som blir skapt/produsert i eit land. BNP omfattar verdiskapinga i all marknadsretta næringsverksemd, dessutan offentleg forvalting, ideelle organisasjonar og produksjon for eigen bruk. BNP per innbyggjar blir ofte nytta som eit mål på velstandsnivået i eit land. SSB', 1798, '2018-05-09T15:56:08Z', '2018-09-04T08:31:26Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Empati', 'Empati er evnen til å forstå en annens sinnstilstand eller følelser.', 120539, '2018-05-27T22:42:41Z', '2018-09-04T06:06:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Empati', 'Empati er evna til å forstå sinnstilstanden eller kjenslene til ein annan person.', 120539, '2018-05-27T22:42:41Z', '2018-09-04T06:06:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kondensat', 'Naturgasskondensat er i gassform i reservoaret, men kondenserer til væske når temperaturen blir redusert til under duggpunktet til rågass. Temperaturfallet inntreffer vanligvis i produksjonsrøret på vei fra reservoar til overflaten, eller i overflateutstyret.', 151148, '2018-06-22T15:42:09Z', '2018-09-04T08:43:46Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kondensat', 'Naturgasskondensat er i gassform i reservoaret, men kondenserer til væske når temperaturen blir redusert til under duggpunktet til rågass. Temperaturfallet inntreffer vanligvis i produksjonsrøret på vei fra reservoar til overflaten, eller i overflateutstyret.', 151148, '2018-06-22T15:42:09Z', '2018-09-04T08:43:46Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('DP - Dynamisk Posisjonering', 'DP: Dynamic Positioning, datastyrt navigasjonssystem som bruker satellittkommunikasjon for å holde fartøyet i samme posisjon uansett bølger, vind og strøm i havet. Navigasjonssystemet kommuniserer med systemet for sidepropeller (truster) for å holde fartøyet i posisjon.', 141020, '2018-06-22T15:29:52Z', '2018-08-17T14:22:15Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('DP - Dynamisk Posisjonering', 'DP; Dynamic Positioning, datastyrt navigeringssystem som bruker satelittkommunikasjon for å holde fartøyet i samme posisjon uansett bølger, vind og strøm i havet. Navigasjonssystemet kommuniserer med systemet for sidepropeller (truster) for å holde fartøyet i posisjon.', 141020, '2018-06-22T15:29:52Z', '2018-08-17T14:22:15Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Asfaltener', 'Asfaltener (uttale: asfaltˈener), kompliserte hydrokarboner som også kan inneholde mindre mengder nitrogen, oksygen og svovel. Utgjør hovedkomponentene i asfalt og er en av komponentene i tunge fyringsoljer. Visse råoljer (særlig i Venezuela) inneholder asfaltener, for øvrig dannes de ved raffinering av olje. De er løselige i benzen og karbondisulfid, uløselige i n-heptan.', 146360, '2018-06-22T15:39:31Z', '2018-09-04T08:44:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Asfaltener', 'Asfaltener (uttale: asfaltˈener), kompliserte hydrokarboner som også kan inneholde mindre mengder nitrogen, oksygen og svovel. Utgjør hovedkomponentene i asfalt og er en av komponentene i tunge fyringsoljer. Visse råoljer (særlig i Venezuela) inneholder asfaltener, for øvrig dannes de ved raffinering av olje. De er løselige i benzen og karbondisulfid, uløselige i n-heptan.', 146360, '2018-06-22T15:39:31Z', '2018-09-04T08:44:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kaliper', 'Kaliper; et måleinstrument som kan gi avtrykk av utvendig eller innvendig diameter. To (eller flere for innvendig type) "armer" i stål er festet i et sentralt punkt. Armene er enten kurvet utover (for innvendig måling) eller innover (for utvendig måling). Når kaliper føres over diameteren justeres armene inn til veggen. Kaliperen leses av med skyvelære eller digitalt for å finne nøyaktig diameter.', 148218, '2018-06-22T15:43:21Z', '2018-09-04T08:44:45Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kaliper', 'Kaliper; et måleinstrument som kan gi avtrykk av utvendig eller innvendig diameter. To (eller flere for innvendig type) "armer" i stål er festet i et sentralt punkt. Armene er enten kurvet utover (for innvendig måling) eller innover (for utvendig måling). Når kaliper føres over diameteren justeres armene inn til veggen. Kaliperen leses av med skyvelære eller digitalt for å finne nøyaktig diameter.', 148218, '2018-06-22T15:43:21Z', '2018-09-04T08:44:45Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('middelavstand', 'Middelvannstanden er havets gjennomsnittshøyde fra havbunnen, målt i tidsrommet mellom høy- og lavvann. På engelsk MSL: Mean Sea Level.', 141018, '2018-06-22T15:29:59Z', '2018-08-17T14:21:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('middelavstand', 'middelavstanden er et resultat av havets gjennomsnittshøyde fra havbunnen, målt i tidsrommet mellom høy- og lavvann. På engelsk MSL: Mean Sea Level.', 141018, '2018-06-22T15:29:59Z', '2018-08-17T14:21:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('OD', 'OD = outer diameter = utvendig diameter', 137719, '2018-06-22T15:30:01Z', '2018-08-17T14:21:43Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('OD', 'OD = outer diameter = utvendig diameter', 137719, '2018-06-22T15:30:01Z', '2018-08-17T14:21:43Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('ID', 'ID = inner diameter = indre diameter', 137720, '2018-06-22T15:30:00Z', '2018-08-17T14:21:42Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('ID', 'ID = inner diameter = indre diameter', 137720, '2018-06-22T15:30:00Z', '2018-08-17T14:21:42Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Motion Reference Unit-MRU', 'MRU er en serie bevegelsessensorer som måler rullebevegelser, topp og bunn i bølgebevegelse, rotasjon rundt senterakse og vertikalbevegelse i forhold til et Nonepunkt. MRU sender signaler til et reaktivt system, vanligvis hiv-kompenserings- eller dynamisk posisjoneringssystem, som utløser motvirkende bevegelser.', 156620, '2018-06-22T15:32:08Z', '2018-08-17T14:22:07Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Motion Reference Unit-MRU', 'MRU er en serie bevegelsessensorer som måler rullebevegelser, topp og bunn i bølgebevegelse, rotasjon rundt senterakse og vertikalbevegelse i forhold til et Nonepunkt. MRU sender signaler til et reaktivt system, vanligvis hiv-kompenserings- eller dynamisk posisjoneringssystem, som utløser motvirkende bevegelser.', 156620, '2018-06-22T15:32:08Z', '2018-08-17T14:22:07Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kompatibel', 'Kompatibel betyr at noe kan virke sammen, er forenlig, passer til.', 153315, '2018-06-22T15:35:20Z', '2018-09-04T08:43:30Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kompatibel', 'Kompatibel betyr at noe kan virke sammen, er forenlig, passer til.', 153315, '2018-06-22T15:35:20Z', '2018-09-04T08:43:30Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('HEC ', 'HEC (hydroksyetylcellulose) er en polymer som blir brukt som et viskositetsøkende middel i saltløsninger som for eksempel kompletteringsvæsker og drill-in-væsker. HEC gir pseudoplastisk reologi, men utvikler egentlig ingen gelstyrke.', 151883, '2018-06-22T15:36:20Z', '2018-09-04T08:43:44Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('HEC ', 'HEC (hydroksyetylcellulose) er en polymer som blir brukt som et viskositetsøkende middel i saltløsninger som for eksempel kompletteringsvæsker og drill-in-væsker. HEC gir pseudoplastisk reologi, men utvikler egentlig ingen gelstyrke.', 151883, '2018-06-22T15:36:20Z', '2018-09-04T08:43:44Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Rensetog', 'Rensetog; en rad av små volum med væsker (kalles piller) som har ulike oppgaver innen rensing. Oppgavene kan være å løse opp salt, rust, kalk osv. Mellom de aktive væskene er det ofte piller som er viskøse og som hjelper til å holde væskene adskilt. Et rensetog kan ledes og følges av pigger, men det er ikke alltid nødvendig.', 148214, '2018-06-22T15:43:25Z', '2018-09-04T08:44:53Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Rensetog', 'Rensetog; en rad av små volum med væsker (kalles piller) som har ulike oppgaver innen rensing. Oppgavene kan være å løse opp salt, rust, kalk osv. Mellom de aktive væskene er det ofte piller som er viskøse og som hjelper til å holde væskene adskilt. Et rensetog kan ledes og følges av pigger, men det er ikke alltid nødvendig.', 148214, '2018-06-22T15:43:25Z', '2018-09-04T08:44:53Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Holde vinkel', 'Å holde vinkel i en brønn betyr at man fortsetter boringen i den retningen (vinkelen) man har, uten å droppe eller bygge vinkel.', 149580, '2018-06-22T15:34:12Z', '2018-09-04T08:43:31Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Holde vinkel', 'Å holde vinkel i en brønn betyr at man fortsetter boringen i den retningen (vinkelen) man har, uten å droppe eller bygge vinkel.', 149580, '2018-06-22T15:34:12Z', '2018-09-04T08:43:31Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Moment', 'Moment er resultatet av kraft multiplisert med arm når noe skal skrus sammen. En momenttrekker kan stilles inn slik at den stopper når ønsket moment er oppnådd.', 161839, '2018-06-22T15:30:54Z', '2018-08-17T14:18:42Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Moment', 'Moment er resultatet av kraft multiplisert med arm når noe skal skrus sammen. En momenttrekker kan stilles inn slik at den stopper når ønsket moment er oppnådd.', 161839, '2018-06-22T15:30:54Z', '2018-08-17T14:18:42Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Pådrag', 'Å gi et pådrag betyr å tilføre noe mer; det kan være energi, masse, væske, lyd, hastighet osv.', 156621, '2018-06-22T15:32:07Z', '2018-08-17T14:22:04Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Pådrag', 'Å gi et pådrag betyr å tilføre noe mer; det kan være energi, masse, væske, lyd, hastighet osv.', 156621, '2018-06-22T15:32:07Z', '2018-08-17T14:22:04Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('ID', 'ID (Inner Diameter). Diameter målt innvendig i et rør eller en sylinder (hull).', 140968, '2018-06-22T15:31:50Z', '2018-09-04T08:43:29Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('ID', 'ID (Inner Diameter). Diameter målt innvendig i et rør eller en sylinder (hull).', 140968, '2018-06-22T15:31:50Z', '2018-09-04T08:43:29Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Chokeventil', 'Chokeventil (egentlig strupeventil). Strupeventil brukes til å begrense utstrømning av væske fra en kilde (brønnen). Når strupeventilen er delvis åpen vil det forekomme et trykkfall forbi ventilen.', 156209, '2018-06-22T15:38:59Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Chokeventil', 'Chokeventil (egentlig strupeventil). Strupeventil brukes til å begrense utstrømning av væske fra en kilde (brønnen). Når strupeventilen er delvis åpen vil det forekomme et trykkfall forbi ventilen.', 156209, '2018-06-22T15:38:59Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Bygge vinkel', 'Å bygge vinkel i en brønn vil si å endre brønnens vinkel fra vertikal (0°) mot horisontal (90°).', 149577, '2018-06-22T15:34:13Z', '2018-09-04T08:43:37Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Bygge vinkel', 'Bygge vinkel i en brønn vil si å endre brønnens vinkel fra vertikal (0°) mot horisontal (90°).', 149577, '2018-06-22T15:34:13Z', '2018-09-04T08:43:37Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('reologi', 'Reologi, læren om flyte- og deformasjonsegenskapene, spesielt i seige væsker. Reologi omhandler hvordan viskositeten endrer seg med endringer i ytre påkjenninger som skjærspenning, trykk m.m. (Kilde: SNL)', 142348, '2018-06-22T15:36:23Z', '2018-09-04T08:44:00Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('reologi', 'Reologi, læren om flyte- og deformasjonsegenskapene, spesielt i seige væsker. Reologi omhandler hvordan viskositeten endrer seg med endringer i ytre påkjenninger som skjærspenning, trykk m.m. (Kilde: SNL)', 142348, '2018-06-22T15:36:23Z', '2018-09-04T08:44:00Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Impermeabel', 'Impermeabel: ugjennomtrengelig, tett.', 151878, '2018-06-22T15:36:18Z', '2018-09-04T08:43:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Impermeabel', 'Impermeabel: ugjennomtrengelig, tett.', 151878, '2018-06-22T15:36:18Z', '2018-09-04T08:43:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('gelstyrke', 'Gelstyrke er væskens evne til å stivne når den stå i ro.', 142350, '2018-06-22T15:36:19Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('gelstyrke', 'Gelstyrke er væskens evne til å stivne når den stå i ro', 142350, '2018-06-22T15:36:19Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Fluid', 'Fluid (engelsk) brukes som en fellesbetegnelse for væske-, gass- og kondensatfase. Vanlig å bruke for reservoar som har flere faser eller gass som kondenserer på grunn av trykkfall.', 150090, '2018-06-22T15:36:24Z', '2018-09-04T08:43:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Fluid', 'Fluid (engelsk) brukes som en fellesbetegnelse for væske-, gass- og kondensatfase. Vanlig å bruke for reservoar som har flere faser eller gass som kondenserer på grunn av trykkfall.', 150090, '2018-06-22T15:36:24Z', '2018-09-04T08:43:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Additiv', 'Additiv: tilsetningsstoff.', 151879, '2018-06-22T15:36:17Z', '2018-09-04T08:43:31Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Additiv', 'Additiv: tilsetningsstoff.', 151879, '2018-06-22T15:36:17Z', '2018-09-04T08:43:31Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kravspesifikasjon', 'En kravspesifikasjon er de kravene som stilles til et produkt. Når man ber om et anbud, er det vanlig å stille visse krav til produktet. Er det for eksempel mat til en polekspedisjon, stilles det krav om holdbarhet og næringsinnhold.', 186758, '2018-05-27T22:24:27Z', '2018-09-04T08:44:47Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kravspesifikasjon', 'Ein kravspesifikasjon er dei krava som blir stilte til eit produkt. Når ein ber om eit anbod, er det vanleg å stille visse krav til produktet. Gjeld det til dømes mat til ein polekspedisjon, stiller ein krav om haldbarheit og næringsinnhald.', 186758, '2018-05-27T22:24:27Z', '2018-09-04T08:44:47Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Pigg', 'Pigg (engelsk: pig) er en plugg som skyves gjennom rør ved hjelp av væske som pumpes bak piggen. Differensialtrykket forskyver piggen og væsken/gassen foran denne. Piggen sendes inn i og tas ut av rørledningen i spesielle stasjoner som er koblet til rørledningen. Piggens oppgave kan være å rense røret, skrape innsiden, kalibrere (måle) innvendig diameter, osv.', 146117, '2018-06-22T15:43:24Z', '2018-09-04T08:44:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Pigg', 'Pigg (engelsk: pig) er en plugg som skyves gjennom rør ved hjelp av væske som pumpes bak piggen. Differensialtrykket forskyver piggen og væsken/gassen foran denne. Piggen sendes inn i og tas ut av rørledningen i spesielle stasjoner som er koblet til rørledningen. Piggens oppgave kan være å rense røret, skrape innsiden, kalibrere (måle) innvendig diameter, osv.', 146117, '2018-06-22T15:43:24Z', '2018-09-04T08:44:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Koalescerplater', 'Koalescerplater har en overflate som samler små dråper som tiltrekkes hverandre og danner større dråper. Når dråpene blir større, faller de ned i væskefasen. Dråpenes startstørrelse kan være i væske- eller dampform.', 150195, '2018-06-22T15:39:25Z', '2018-09-04T08:43:42Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Koalescerplater', 'Koalescerplater har en overflate som samler små dråper som tiltrekkes hverandre og danner større dråper. Når dråpene blir større faller de ned i væskefasen. Dråpenes startstørrelse kan være i væske- eller dampform.', 150195, '2018-06-22T15:39:25Z', '2018-09-04T08:43:42Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Idémyldring', 'Idémyldring er ein teknikk der fleire personar i eit møte kastar fram flest mogleg idear om eit tema. Alle idear blir helste velkomne utan kritikk. Først seinare går vi kritisk gjennom dei ideane som er komne fram.', 91118, '2018-05-04T20:57:48Z', '2018-09-04T06:40:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Idémyldringsteknikker', 'Idémyldring er en teknikk der flere personer i et møte kaster fram så mange ideer som overhodet mulig om et tema. Alle ideer mottas uten kritikk. Først seinere tar vi en kritisk gjennomgang av ideene som ble fremmet.', 91118, '2018-05-04T20:57:48Z', '2018-09-04T06:40:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Idémyldringsteknikkar', 'Idémyldring er ein teknikk der fleire personar i eit møte kastar fram flest mogleg idear om eit tema. Alle idear blir helste velkomne utan kritikk. Først seinare går vi kritisk gjennom dei ideane som er komne fram.', 91118, '2018-05-04T20:57:48Z', '2018-09-04T06:40:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('forskrift', 'En forskrift er en rettslig bindende regulering som må ha hjemmel i gyldig lov. Forskriften må holde seg innenfor lovhjemmelen, og må ikke være i strid med andre lover.', 188149, '2018-05-27T22:44:21Z', '2018-09-04T08:45:05Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('forskrift', 'Ei forskrift er ei rettsleg bindande regulering som må ha heimel i gyldig lov. Forskrifta må halde seg innanfor lovheimelen, og må ikkje vere i strid med andre lover', 188149, '2018-05-27T22:44:21Z', '2018-09-04T08:45:05Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('absolutt', 'Et absolutt filter fjerner 99,98 % av partiklene som er større enn den oppgitte filtreringsstørrelsen (> µ Rating).', 142352, '2018-06-22T15:39:52Z', '2018-09-04T08:43:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('absolutt', 'Absolutt filter fjerner 99.98% av partiklene som er større enn den oppgitte filtreringsstørrelsen (> µ Rating)', 142352, '2018-06-22T15:39:52Z', '2018-09-04T08:43:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Scale', 'Scale (engelsk) er kalsiumkarbonat fra formasjonsvann som følger med olje og gass fra reservoaret. På grunn av trykk- og temperaturfall fra reservoaret skilles mineraler ut fra væsken. Scale fester seg på produksjonsrørets innside. Problemet som oppstår er at rørets indre diameter blir mindre, og det påvirker produksjonen.', 150091, '2018-06-22T15:39:28Z', '2018-09-04T08:43:52Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Scale', 'Scale (engelsk) er kalsiumkarbonat fra formasjonsvann som følger med olje og gass fra reservoaret. På grunn av trykk- og temperaturfall fra reservoaret skilles mineraler ut fra væsken. Scale fester seg på produksjonsrørets innside. Problemet som oppstår er at rørets indre diameter blir mindre, og det påvirker produksjonen.', 150091, '2018-06-22T15:39:28Z', '2018-09-04T08:43:52Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('nominelt', 'Et nominelt filter fjerner 90 % av partiklene som er større enn den gitte filtreringsstørrelsen.', 142353, '2018-06-22T15:39:52Z', '2018-09-04T08:43:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('nominelt', 'Nominelt filter fjerner 90% av partiklene som er større enn den gitte filtreringsstørrelsen.', 142353, '2018-06-22T15:39:52Z', '2018-09-04T08:43:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Surfaktant', 'Surfaktant; (fra amerikansk: surface active agent, surfactant) er en kjemisk forbindelse som reduserer overflatespenningen i en væske slik at den lettere kan blandes med andre væsker. Såpe i vaskevann oppfører seg som en surfaktant slik at vannet kan løsne fett.', 148219, '2018-06-22T15:43:34Z', '2018-09-04T08:44:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Surfaktant', 'Surfaktant; (fra amerikansk: surface active agent, surfactant) er en kjemisk forbindelse som reduserer overflatespenningen i en væske slik at den lettere kan blandes med andre væsker. Såpe i vaskevann oppfører seg som en surfaktant slik at vannet kan løsne fett.', 148219, '2018-06-22T15:43:34Z', '2018-09-04T08:44:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('TVD', 'TVD; engelsk True Vertical Depth. Vertikal høyde/dybde. En brønn måles vertikalt fra RKB til TVD.', 157471, '2018-06-22T15:39:03Z', '2018-09-04T08:43:34Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('TVD', 'TVD; engelsk True Vertical Depth. Vertikal høyde/dybde. En brønn måles vertikalt fra RKB til TVD.', 157471, '2018-06-22T15:39:03Z', '2018-09-04T08:43:34Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('IBOP', 'IBOP - Internal Blow Out Preventer, er en sikringsventil som er montert i øverste del av borestrengen i Topdrive. Den skal hindre utblåsning gjennom borestrengen på overflaten. Den er automatisk og stenger dersom det oppstår trykk fra undersiden i borestrengen. Den kan også stenges via styringspanelet i Drillers Cabin. Det finnes også en egen type IBOP som kan monteres i borestrengen og føres inn i brønnen.', 158998, '2018-06-22T15:30:42Z', '2018-09-04T08:43:53Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('IBOP ', 'IBOP - Internal Blow Out Preventer, er en sikringsventil som er montert i øverste del av borestrengen i Topdrive. Den skal hindre utblåsning gjennom borestrengen på overflaten. Den er automatisk og stenger dersom det oppstår trykk fra undersiden i borestrengen. Den kan også stenges via styringspanelet i Drillers Cabin. Det finnes også en egen type IBOP som kan monteres i borestrengen og føres inn i brønnen.', 158998, '2018-06-22T15:30:42Z', '2018-09-04T08:43:53Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Manifold ', 'Manifold er et rørsystem som leder væske eller gass inn fra flere grener til et sentralt punkt (manifolden), og derfra og ut til flere grener. I en manifold er det vanligvis et system av ventiler som gjør at man kan åpne og stenge til- og fra-rørene etter behov.', 150088, '2018-06-22T15:39:28Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Manifold ', 'Manifold er et rørsystem som leder væske eller gass inn fra flere grener til et sentralt punkt (manifolden) og ut til flere grener. I en manifold er det vanligvis et system av ventiler som gjør at man kan åpne og stenge til- og fra- rørene etter behov.', 150088, '2018-06-22T15:39:28Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Rate', 'Rate er en forenkling av uttrykket strømningsrate som oppgis i volum per tidsenhet (f.eks. liter/minutt).', 150245, '2018-06-22T15:42:11Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Rate', 'Rate er en forenkling av uttrykket strømningsrate som oppgis i volum per tidsenhet (f.eks. liter/minutt).', 150245, '2018-06-22T15:42:11Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Topdrive', 'Topdrive er selve boreinnretningen som vandrer opp og ned og roterer i en borerigg.', 148602, '2018-06-22T15:46:04Z', '2018-09-04T08:43:56Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Topdrive', 'Topdrive er selve boreinnretningen som vandrer opp og ned og roterer i en borerigg.', 148602, '2018-06-22T15:46:04Z', '2018-09-04T08:43:56Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Korrosjonsinhibitor', 'Korrosjonsinhibitor; tilsetningsstoff (vanligvis kjemikalier) som reduserer eller forsinker korrosjonsskade på utstyr. Tilsetningsstoffet kan danne en beskyttende film på overflaten av utstyret, eller danne kjemisk binding med skadelige stoffer i væsken.', 148193, '2018-06-22T15:43:25Z', '2018-09-04T08:44:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Korrosjonsinhibitor', 'Korrosjonsinhibitor; tilsetningsstoff (vanligvis kjemikalier) som reduserer eller forsinker korrosjonsskade på utstyr. Tilsetningsstoffet kan danne en beskyttende film på overflaten av utstyret, eller danne kjemisk binding med skadelige stoffer i væsken.', 148193, '2018-06-22T15:43:25Z', '2018-09-04T08:44:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Safety', 'Safety er sikkerhetslederen om bord på en plattform. Han er ansvarlig for at alt innen HMS er tilfredsstillende.', 148806, '2018-06-22T15:45:59Z', '2018-08-17T14:10:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Safety', 'Safety er sikkerhetslederen om bord på en plattform. Han er ansvarlig for at alt innen HMS er tilfredsstillende.', 148806, '2018-06-22T15:45:59Z', '2018-08-17T14:10:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Koalesens', 'Koalesens er en prosess der to eller flere dråper eller partikler slår seg sammen ved kontakt til å danne en enkel dråpe.', 149945, '2018-06-22T15:39:26Z', '2018-09-04T08:43:46Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Koalesens', 'Koalesens er en prosess der to eller flere dråper eller partikler slår seg sammen ved kontakt til å danne en enkel dråpe.', 149945, '2018-06-22T15:39:26Z', '2018-09-04T08:43:46Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('MD', 'MD; engelsk Measured Depth. Målt lengde/dybde. Brønnens lengde fra RKB til bunnen i hullet.', 157472, '2018-06-22T15:37:50Z', '2018-09-04T08:43:47Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('MD', 'MD; engelsk Measured Depth. Målt lengde/dybde. Brønnens lengde fra RKB til bunnen i hullet.', 157472, '2018-06-22T15:37:50Z', '2018-09-04T08:43:47Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Nedstrøms ', 'Nedstrøms viser til et område etter kilden (startpunkt), i samme retning som strømmen.', 151152, '2018-06-22T15:42:08Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Nedstrøms ', 'Nedstrøms viser til et område etter kilden (startpunkt), i samme retning som strømmen.', 151152, '2018-06-22T15:42:08Z', '2018-09-04T08:43:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Inhibere', 'Inhibere betyr å hemme eller hindre, vanligvis å hemme/hindre en kjemisk reaksjon. Ordet brukes ofte i betydningen "å tilsette" - for å hindre...', 146136, '2018-06-22T15:43:22Z', '2018-09-04T08:44:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Inhibere', 'Inhibere betyr å hemme eller hindre, vanligvis å hemme/hindre en kjemisk reaksjon. Ordet brukes ofte i betydningen "å tilsette" - for å hindre...', 146136, '2018-06-22T15:43:22Z', '2018-09-04T08:44:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('FBE', 'FBE- Fusion Bonded Epoxy, (flytende plastmasse/kunstig harpiks) Masse/pulver som sprayes på en forvarmet overflate. Kan legges i flere lag for ekstra beskyttelse mot det ytre miljø.', 146248, '2018-06-22T15:43:14Z', '2018-09-04T08:44:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('FBE', 'FBE- Fusion Bonded Epoxy, (flytende plastmasse/kunstig harpiks) Masse/pulver som sprayes på en forvarmet overflate. Kan legges i flere lag for ekstra beskyttelse mot det ytre miljø.', 146248, '2018-06-22T15:43:14Z', '2018-09-04T08:44:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Hydrat', 'Hydrater er isdannelse som oppstår når lette hydrokarbonforbindelser som f.eks. metangass sammen med vann kommer i et miljø med høyt trykk og lav temperatur. Hydrater opptrer som is-slush i oljeproduksjon og som is-linser i gassrør. Hydratene kan redusere produksjonen eller plugge den helt. En hydratplugg er vanskelig å løse opp, og det tilsettes derfor MEG i produksjonsløpet for å hindre hydratdannelse.', 146127, '2018-06-22T15:39:30Z', '2018-09-04T08:44:49Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Hydrat', 'Hydrater er isdannelse som oppstår når lette hydrokarbonforbindelser som f.eks. metangass sammen med vann kommer i et miljø med høyt trykk og lav temperatur. Hydrater opptrer som is-slush i oljeproduksjon og som is-linser i gassrør. Hydratene kan redusere produksjonen eller plugge den helt. En hydratplugg er vanskelig å løse opp, og det tilsettes derfor MEG i produksjonsløpet for å hindre hydratdannelse.', 146127, '2018-06-22T15:39:30Z', '2018-09-04T08:44:49Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Negativ oppdrift', 'Beskrivelse av en situasjon der en gjenstand er så tung at den ikke vil flyte opp fra bunnen i en væske', 148157, '2018-06-22T15:43:13Z', '2018-09-04T08:44:13Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Negativ oppdrift', 'Beskrivelse av en situasjon der en gjenstand er så tung at den ikke vil flyte opp fra bunnen i en væske', 148157, '2018-06-22T15:43:13Z', '2018-09-04T08:44:13Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Hydrokarbonder (HC)', 'Hydrokarboner (HC) er organisk-kjemiske forbindelser som kun består av hydrogen (H) og karbon (C). De kan være av flere typer alt etter antall hydrogen og karbon atomer, og hvordan de kjemiske bindinger i molekylene varierer.', 148678, '2018-06-22T15:46:09Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Hydrokarboner (HC)', 'Hydrokarboner (HC) er organisk-kjemiske forbindelser som kun består av hydrogen (H) og karbon (C). De kan være av flere typer alt etter antall hydrogen og karbon atomer, og hvordan de kjemiske bindinger i molekylene varierer.', 148678, '2018-06-22T15:46:09Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Verneombud', 'Verneombud er en arbeidstaker som er valgt av sine kolleger og skal ivareta arbeidstakernes interesser i saker som angår arbeidsmiljøet. Verneombudet trer inn i saken dersom ikke arbeidstakeren selv får til en løsning. Verneombudet skal melde fra til Safety om utilfredsstillende forhold.', 148807, '2018-06-22T15:45:58Z', '2018-08-17T14:10:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Verneombud', 'Verneombud er en arbeidstaker som er valgt av sine kolleger og skal ivareta arbeidstakernes interesser i saker som angår arbeidsmiljøet. Verneombudet trer inn i saken dersom ikke arbeidstakeren selv får til en løsning. Verneombudet skal melde fra til Safety om utilfredsstillende forhold.', 148807, '2018-06-22T15:45:58Z', '2018-08-17T14:10:38Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('BOP', 'BOP; Blow Out Preventor, på norsk "utblåsningssikring", monteres på brønnen når man skal gjennomføre bore- og brønnaktiviteter. Har flere ulike ventiler som kan stenge brønnen mot det ytre miljø (se detaljer i eget emne).', 141021, '2018-06-22T15:30:02Z', '2018-09-04T08:43:59Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('BOP', 'BOP; Blow Out Preventor, på norsk "utblåsningssikring", monteres på brønnen når man skal gjennomføre bore- og brønnaktiviteter. Har flere ulike ventiler som kan stenge brønnen mot det ytre miljø (se detaljer i eget emne).', 141021, '2018-06-22T15:30:02Z', '2018-09-04T08:43:59Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Alkaner', 'Alkaner (tidl. parafiner), organiske forbindelser som bare består av karbon og hydrogen (hydrokarboner). Generell formel for alkaner er CnH2n+2. Noen av de mest kjente alkanene er metan CH4; etan C2H6; propan C3H8; butan C4H10; pentan C5H12 og heksan C6H14.', 146358, '2018-06-22T15:43:36Z', '2018-09-04T08:44:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Alkaner', 'Alkaner (tidl. parafiner), organiske forbindelser som bare består av karbon og hydrogen (hydrokarboner). Generell formel for alkaner er CnH2n+2. Noen av de mest kjente alkanene er metan CH4; etan C2H6; propan C3H8; butan C4H10; pentan C5H12 og heksan C6H14.', 146358, '2018-06-22T15:43:36Z', '2018-09-04T08:44:41Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Katodisk beskyttelse', 'Katodisk beskyttelse: Ved kontakt mellom forskjellige metaller i en elektrolytisk blanding (sjøvann), betegnes det metallet som er mest edelt som katode (beskyttet), det andre metallet er anode (offer).', 148149, '2018-06-22T15:43:14Z', '2018-09-04T08:44:14Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Katodisk beskyttelse', 'Katodisk beskyttelse: Ved kontakt mellom forskjellige metaller i en elektrolytisk blanding (sjøvann), betegnes det metallet som er mest edelt som katode (beskyttet), det andre metallet er anode (offer).', 148149, '2018-06-22T15:43:14Z', '2018-09-04T08:44:14Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Tennkilde', 'Tennkilde er det utstyret en bruker til antennelse. Om en tenner på et stearinlys med en fyrstikk, er fyrstikken tennkilde.', 148672, '2018-06-22T15:46:11Z', '2018-09-04T08:44:04Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Tennkilde', 'Tennkilde er det utstyret en bruker til antennelse. Om en tenner på et stearinlys med en fyrstikk, er fyrstikken tennkilde.', 148672, '2018-06-22T15:46:11Z', '2018-09-04T08:44:04Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Manrider', 'Manrider er en personellvinsj hvor en kan kjøre en person i ridebelte opp i den høyden hvor det er arbeid som skal utføres.', 148837, '2018-06-22T15:46:27Z', '2018-09-04T08:43:51Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Manrider', 'Manrider er en personellvinsj hvor en kan kjøre en person i ridebelte opp i den høyden hvor det er arbeid som skal utføres.', 148837, '2018-06-22T15:46:27Z', '2018-09-04T08:43:51Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Tenntemperatur', 'Tenntemperatur forteller noe om hvilken temperatur en trenger for å skape antennelse på et material.', 148673, '2018-06-22T15:46:11Z', '2018-09-04T08:43:59Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Tenntemperatur', 'Tenntemperatur forteller noe om hvilken temperatur en trenger for å skape antennelse på et material.', 148673, '2018-06-22T15:46:11Z', '2018-09-04T08:43:59Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Åndedrettsvern', 'Åndedrettsvern består av en maske som skal dekke munn og nese, og brukes med filter eller trykkluftflasker for å beskytte luftveiene og lungene mot uønsket gass eller partikler.', 148676, '2018-06-22T15:46:10Z', '2018-09-04T08:43:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Åndedrettsvern', 'Åndedrettsvern består av en maske som skal dekke munn og nese, og brukes med filter eller trykkluftflasker for å beskytte luftveiene og lungene mot uønsket gass eller partikler.', 148676, '2018-06-22T15:46:10Z', '2018-09-04T08:43:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Friskluftmaske', 'Friskluftmaske: Maske som dekker nese og munn og som har tilført pusteluft.', 148661, '2018-06-22T15:46:15Z', '2018-09-04T08:43:51Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Friskluftmaske', 'Friskluftmaske: Maske som dekker nese og munn og som har tilført pusteluft.', 148661, '2018-06-22T15:46:15Z', '2018-09-04T08:43:51Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Merverdiavgift', 'Merverdiavgift er en generell forbruksavgift på verdien som blir lagt til varer eller tjenester i hvert handels- eller produksjonsledd. (Wikipedia)', 187646, '2018-05-27T22:40:09Z', '2018-09-04T08:45:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Meirverdiavgift', 'Meirverdiavgift er ei generell forbruksavgift på verdien som blir lagd til varer eller tenester i kvart handels- eller produksjonsledd. (Wikipedia)', 187646, '2018-05-27T22:40:09Z', '2018-09-04T08:45:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('LWD', 'LWD: Logging While Drilling. Verktøy i BHA som kan logge formasjonsegenskaper som densitet, porøsitet, trykk osv. mens man borer. Sparer masse tid i kontrast til Wireline logging som kjøres etter at borestrengen er trukket ut.', 140798, '2018-06-22T15:34:30Z', '2018-09-04T08:43:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('LWD', 'LWD: Logging While Drilling. Verktøy i BHA som kan logge formasjonsegenskaper som densitet, porøsitet, trykk osv. mens man borer. Sparer masse tid i kontrast til Wireline logging som kjøres etter at borestrengen er trukket ut.', 140798, '2018-06-22T15:34:30Z', '2018-09-04T08:43:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Ringrom', 'Ringrommet (annulus på engelsk) er området mellom to rør som står inni hverandre. I borefasen er området mellom borerørenes utside og brønnens innside omtalt som ringrommet. Når brønnen er ferdig komplettert, kalles ringrommet mellom produksjonsrør og nærmeste foringsrør A-annulus, neste ringrom mellom to foringsrør B-annulus og så videre.', 162509, '2018-06-22T15:33:27Z', '2018-09-04T08:44:14Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Ringrom', 'Ringrommet (annulus på engelsk) er området mellom to rør som står inni hverandre. I borefasen er området mellom borerørenes utside og brønnens innside omtalt som ringrommet. Når brønnen er ferdig komplettert kalles ringrommet mellom produksjonsrør og nærmeste foringsrør A-annulus, neste ringrom mellom to foringsrør B-annulus og så videre.', 162509, '2018-06-22T15:33:27Z', '2018-09-04T08:44:14Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Ridebelte', 'Ridebelte er en sele som er utformet på en slik måte at en person kan være i sittende posisjon når han/hun jobber i høyden.', 148834, '2018-06-22T15:46:28Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Ridebelte', 'Ridebelte er en sele som er designet på en slik måte at en person kan være i en sittende posisjon når en jobber i høyden.', 148834, '2018-06-22T15:46:28Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Proaktiv', 'Proaktiv vil si at en tenker fremover og er forberedt på det som skjer i fremtiden.', 148833, '2018-06-22T15:46:28Z', '2018-09-04T08:43:56Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Proaktiv', 'Proaktiv vil si at en tenker fremover og er forberedt på det som skjer i fremtiden.', 148833, '2018-06-22T15:46:28Z', '2018-09-04T08:43:56Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Statisk', 'Statisk: er i ro, stillestående, i likevekt.', 151877, '2018-06-22T15:36:19Z', '2018-09-04T08:43:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Statisk', 'Statisk: er i ro, stillestående, i likevekt.', 151877, '2018-06-22T15:36:19Z', '2018-09-04T08:43:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Prognose', 'En prognose kan for eksempel være en oversikt over hvordan en bedrift tror at økonomien dens vil se ut de neste månedene, det vil si hvor store inntektene og kostnadene vil bli.', 187631, '2018-05-27T22:39:49Z', '2018-09-04T06:21:02Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Prognose', 'Ein prognose kan til dømes vere ei oversikt over korleis ei bedrift trur at økonomien deira vil sjå ut dei neste månadene, det vil seie kor store inntektene og kostnadene vil bli.', 187631, '2018-05-27T22:39:49Z', '2018-09-04T06:21:02Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Integrere ', 'Å integrere betyr å innlemme som del av eller å innpasse i et hele.', 89124, '2018-05-04T20:56:58Z', '2018-08-20T08:35:27Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Integrere ', 'Å integrere betyr å innlemme som del av eller å innpasse i et hele.', 89124, '2018-05-04T20:56:58Z', '2018-08-20T08:35:27Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Integrere', 'Å integrere er å innlemme som del av eller å innpasse i eit heile.', 89124, '2018-05-04T20:56:58Z', '2018-08-20T08:35:27Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Akselerator', 'En akselerator er et verktøy som brukes sammen med jar (slagverktøy) i BHA for å gi ekstra slagkraft til jaren. Akseleratoren er fleksibel i lengderetningen og bidrar med ekstra strekk i borestrengen når det trekkes for å jare. Akseleratoren overfører strekket til jaren som bevegelsesenergi, slik at jaren kan slå fullt slag på BHA.', 149832, '2018-06-22T15:34:33Z', '2018-09-04T08:43:28Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Akselerator', 'En akselerator er et verktøy som brukes sammen med jar (slagverktøy) i BHA for å gi ekstra slagkraft til jaren. Akseleratoren er fleksibel i lengderetningen og bidrar med ekstra strekk i borestrengen når det trekkes for å jare. Akseleratoren overfører strekket til jaren som bevegelsesenergi, slik at jaren kan slå fullt slag på BHA.', 149832, '2018-06-22T15:34:33Z', '2018-09-04T08:43:28Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Flapper valve', 'Flapper valve (engelsk); klaffventil. Hengslet klaff som holdes av en lett stålfjær og lukkes mot et sete (ring). Klaffen holder tett med trykk på klaffsiden mot setet. Klaffen åpnes ved strømning eller trykk fra setesiden mot stålfjæren.', 149591, '2018-06-22T15:34:15Z', '2018-09-04T08:43:27Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Flapper valve', 'Flapper valve (engelsk); klaff ventil. Hengslet klaff som holdes av en lett stålfjær og lukkes mot et sete (ring). Klaffen holder tett med trykk på klaffsiden mot setet. Klaffen åpnes ved strømning eller trykk fra setesiden mot stålfjæren.', 149591, '2018-06-22T15:34:15Z', '2018-09-04T08:43:27Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('moonpool', 'Åpning i skipsskrog eller riggskrog som gir tilgang til sjøen under boretårnet. Veggene i moonpool er isolert mot vanninntrengning.', 137718, '2018-06-22T15:30:02Z', '2018-08-17T14:21:43Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('moonpool', 'Åpning i skipsskrog eller riggskrog som gir tilgang til sjøen under boretårnet. Veggene i moonpool er isolert mot vanninntrengning.', 137718, '2018-06-22T15:30:02Z', '2018-08-17T14:21:43Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kick', 'Kick, på norsk «brønnspark», er en innstrømning av formasjonsvæsker eller gass i brønnen som bores. Årsaken til kick er at trykket innvendig i brønnen er lavere enn trykket i formasjonen det bores i.', 141019, '2018-06-22T15:29:57Z', '2018-09-04T08:44:05Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Kick', 'Kick, på norsk «brønnspark», er en innstrømning av formasjonsvæsker eller gass i brønnen som bores. Årsaken til kick er at trykket innvendig i brønnen er lavere enn trykket i formasjonen det bores i.', 141019, '2018-06-22T15:29:57Z', '2018-09-04T08:44:05Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('IADC', 'IADC- International Association of Drilling Contractors. En interesseorganisasjon som jobber for å oppnå sikkerhet og effektiv drift i oljerelatert virksomhet. Organisasjonen er særlig kjent for sin rolle innen HMS og brønnkontroll i bore- og brønnoperasjoner.', 160280, '2018-06-22T15:30:58Z', '2018-08-17T14:18:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('IADC', 'IADC- International Association of Drilling Contractors. En interesseorganisasjon som jobber for å oppnå sikkerhet og effektiv drift i oljerelatert virksomhet. Organisasjonen er særlig kjent for sin rolle innen HMS og brønnkontroll i bore- og brønnoperasjoner.', 160280, '2018-06-22T15:30:58Z', '2018-08-17T14:18:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('V-døren', 'V-døren er navnet på åpningen i boretårnet fra boredekk til rørdekk. Åpningen er formet som en opp ned V (Λ) slik at lange rørseksjoner kan trekkes inn på boredekk ute å støte borti tårnets åpning.', 160720, '2018-06-22T15:30:45Z', '2018-08-17T14:18:48Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('V-døren', 'V-døren er navnet på åpningen i boretårnet fra boredekk til rørdekk. Åpningen er formet som en opp-ned V (Λ) slik at lange rørseksjoner kan trekkes inn på boredekk ute å støte borti tårnets åpning.', 160720, '2018-06-22T15:30:45Z', '2018-08-17T14:18:48Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Eagle ', 'The eagle (engelsk) er en rørkrane som er montert i boretårnets framside. Kranen kan strekke seg framover (ut fra tårnet) og hente rør fra catwalken. Kranen vipper røret til vertikal posisjon inne i tårnet. Eagle brukes der catwalken ikke når fram til boredekk.', 161699, '2018-06-22T15:30:49Z', '2018-09-04T08:43:57Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Eagle ', 'The eagle (engelsk) er en rørkrane som er montert i boretårnets framside. Kranen kan strekke seg framover (ut fra tårnet) og hente rør fra catwalken. Kranen vipper røret til vertikal posisjon inne i tårnet. Eagle brukes der catwalken ikke når fram til boredekk.', 161699, '2018-06-22T15:30:49Z', '2018-09-04T08:43:57Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('pseudoplastisk', 'Pseudoplastisk betyr at viskositeten er relativt høy i stillestående form, men minker når væsken utsettes for krefter som for eksempel bevegelseskraften fra sirkulasjonspumpene.', 142346, '2018-06-22T15:39:54Z', '2018-09-04T08:43:46Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('pseudoplastisk', 'Pseudoplastisk betyr at viskositeten er relativt høy i stillestående form, men minker når væsken utsettes for krefter som f.eks bevegelseskraften som kommer fra sirkulasjonspumpene.', 142346, '2018-06-22T15:39:54Z', '2018-09-04T08:43:46Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('SJA - sikker jobb analyse', 'SJA – sikker jobb analyse; dokument og prosess som brukes for å identifisere faremomenter i deler av, eller hele, arbeidsoppdraget. SJA kan medføre endring i AT eller AO før arbeidet kan startes.', 148745, '2018-06-22T15:46:16Z', '2018-09-04T08:43:56Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('SJA - sikker jobb analyse', 'SJA - sikker jobb analyse; dokument og prosess som brukes for å identifisere faremomenter i deler av, eller hele, arbeidsoppdraget. SJA kan medføre endring i AT eller AO før arbeidet kan startes.', 148745, '2018-06-22T15:46:16Z', '2018-09-04T08:43:56Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Skin - formasjonsskade', 'Skin er engelsk og beskriver formasjonsskade som er påført i nær-brønn området på grunn av bore- eller kompletteringsvæske eller mekanisk skade fra bore- eller kompletteringsutstyr. Skin er redusert permeabilitet.', 153513, '2018-06-22T15:35:23Z', '2018-09-04T08:43:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Skin - formasjonsskade', 'Skin er engelsk og beskriver formasjonsskade som er påført i nær-brønn området på grunn av bore- eller kompletteringsvæske eller mekanisk skade fra bore- eller kompletteringsutstyr. Skin er redusert permeabilitet.', 153513, '2018-06-22T15:35:23Z', '2018-09-04T08:43:39Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Stand', 'Stand (engelsk) er to eller flere borerør som er skrudd sammen. Det er vanlig med to lange eller tre middels lange rør. Et stand plasseres i fingerbordet mellom bruk. Innkjøring og uttrekking av borerørene er mer effektivt når kun hver andre eller hver tredje gjengeforbindelse brukes.', 160716, '2018-06-22T15:30:46Z', '2018-09-04T08:43:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Stand', 'Stand (engelsk) er to eller flere borerør som er skrudd sammen. Det er vanlig med to lange eller tre middels lange rør. Et stand plasseres i fingerbordet mellom bruk. Innkjøring og uttrekking av borerørene er mer effektiv når kun hver andre eller hver tredje gjengeforbindelse brukes.', 160716, '2018-06-22T15:30:46Z', '2018-09-04T08:43:33Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Pipedeck ', 'Pipedeck er et dekkområde utenfor boredekk der det oppbevares alle typer borerør og annet utstyr som skal brukes i forbindelse med bore- og brønnoperasjoner.', 148637, '2018-06-22T15:46:33Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Pipedeck ', 'Pipedeck er et dekkområde utenfor boredekk der det oppbevares alle typer borerør og annet utstyr som skal brukes i forbindelse med bore- og brønnoperasjoner.', 148637, '2018-06-22T15:46:33Z', '2018-09-04T08:43:54Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Links', 'Links (engelsk). To lenker som brukes som forlengere for å henge elevator eller tilsvarende under top drive eller i kroken under løpeblokken. Et annet ord for links på englsk er bails, som er omskrevet til «beiler» på norsk. Linksene er utformet som en stålstang med løkker (øye) i hver ende. De leveres med ulike lengder og løftebegrensninger etter bestilling.', 160712, '2018-06-22T15:30:47Z', '2018-08-17T14:18:52Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Links', 'Links (engelsk). Lenker (to) som brukes som forlengere for å henge elevator eller tilsvarende under top drive eller i kroken under løpeblokken. Et annet ord for links på englsk er bails, som er omskrevet til «beiler» på norsk. Links er utformet som en stålstang med løkker (øye) i hver ende. Links leveres med ulike lengder og løftebegrensninger etter bestilling.', 160712, '2018-06-22T15:30:47Z', '2018-08-17T14:18:52Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Killmud', 'Killmud betyr drepeslam. Det brukes når brønnen er i underbalanse i forhold til formasjonstrykket. Killmud veies opp til høyere densitet enn boreslammet og holdes klart om bord i tilfelle det blir behov for det. Killmud sirkuleres inn i brønnen for å gjenopprette balanse mot formasjonstrykket.', 149356, '2018-06-22T15:31:05Z', '2018-08-17T14:19:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Killmud', 'Killmud betyr drepeslam. Det brukes når brønnen er i underbalanse i forhold til formasjonstrykket. Killmud veies opp til høyere densitet enn boreslammet og holdes klart om bord i tilfelle det blir behov for det. Killmud sirkuleres inn i brønnen for å gjenopprette balanse mot formasjonstrykket.', 149356, '2018-06-22T15:31:05Z', '2018-08-17T14:19:55Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Margin', 'Grense, området mellom to grenseverdier (f.eks høy og lav) er innenfor marginen.', 148137, '2018-06-22T15:36:45Z', '2018-09-04T08:44:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Margin', 'Grense, området mellom to grenseverdier (f.eks høy og lav) er innenfor marginen.', 148137, '2018-06-22T15:36:45Z', '2018-09-04T08:44:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('BHA', 'BHA: Bottom Hole Assembly. Utstyr som skrus sammen og brukes nederst i bore- eller servicestrengen. Utstyret har spesielle oppgaver som f.eks. boring, logging, måling, perforering osv.', 140795, '2018-06-22T15:34:11Z', '2018-09-04T08:43:52Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('BHA', 'BHA: Bottom Hole Assembly. Utstyr som skrus sammen og brukes nederst i bore- eller servicestrengen. Utstyret har spesielle oppgaver som f.eks. boring, logging, måling, perforering osv.', 140795, '2018-06-22T15:34:11Z', '2018-09-04T08:43:52Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Flerfasestrømning', 'Flerfasestrømning, transport av gass, væske og eventuelt faste stoffer i et felles rør. Strømmen fra en petroleumsbrønn som produserer både gass og olje, er et eksempel på flerfasestrømning. (SNL)', 145920, '2018-06-22T15:42:23Z', '2018-09-04T08:44:20Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Flerfasestrømning', 'Flerfasestrømning, transport av gass, væske og eventuelt faste stoffer i et felles rør. Strømmen fra en petroleumsbrønn som produserer både gass og olje, er et eksempel på flerfasestrømning. (SNL)', 145920, '2018-06-22T15:42:23Z', '2018-09-04T08:44:20Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('OD', 'OD (Outer Diameter). Diameteren måles på tvers i enden av røret, inkludert rørgodset.', 145679, '2018-06-22T15:33:53Z', '2018-09-04T08:43:45Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('OD', 'OD (Outer Diameter). Diameteren måles på tvers i enden av røret, inkludert rørgodset.', 145679, '2018-06-22T15:33:53Z', '2018-09-04T08:43:45Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Trippe', 'Trippe kommer av det engelske uttrykket "trip" - reise. Å trippe strengen i brønnen betyr at man trekker strengen ut eller kjører den inn i brønnen. En "roundtrip" betyr at strengen både trekkes ut og kjøres inn igjen med kun et kortere opphold imellom.', 148139, '2018-06-22T15:34:43Z', '2018-09-04T08:44:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Trippe', 'Trippe kommer av det engelske uttrykket "trip" - reise. Å trippe strengen i brønnen betyr at man trekker strengen ut eller kjører den inn i brønnen. En "roundtrip" betyr at strengen både trekkes ut og kjøres inn igjen med kun et kortere opphold imellom.', 148139, '2018-06-22T15:34:43Z', '2018-09-04T08:44:16Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Drifte', 'Å drifte et rør betyr å kontrollere at den indre diameteren på røret tilfredsstiller kravene. Til det bruker man en drift. Dette er en stang som har nøyaktig og kontrollert ytre diameter. Driften skyves helt gjennom røret som skal kontrolleres. OD drift er på samme måte, men da brukes en utvendig rørdrift som har godkjent toleranse innvendig.', 161679, '2018-06-22T15:30:51Z', '2018-09-04T08:44:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Drifte', 'Å drifte et rør betyr å kontrollere at den indre diameteren på røret tilfredsstiller kravene. Til det bruker man en drift. Dette er en stang som har nøyaktig og kontrollert ytre diameter. Driften skyves helt gjennom røret som skal kontrolleres. OD drift er på samme måte, men da brukes en utvendig rørdrift som har godkjent toleranse innvendig.', 161679, '2018-06-22T15:30:51Z', '2018-09-04T08:44:03Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Reaktiv formasjon', 'Reaktiv formasjon er en formasjonstype som reagerer lett med væske eller salt i væsken og sveller/ekspanderer. Slik reaksjon forårsaker ofte boreproblemer og bør unngås ved valg av riktig sammensetning i borevæsken.', 153353, '2018-06-22T15:36:04Z', '2018-09-04T08:43:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Reaktiv formasjon', 'Reaktiv formasjon er en formasjonstype som reagerer lett med væske eller salt i væsken og sveller/ekspanderer. Slik reaksjon forårsaker ofte boreproblemer og bør unngås ved valg av riktig sammensetning i borevæsken.', 153353, '2018-06-22T15:36:04Z', '2018-09-04T08:43:35Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Polymer', 'Polymerer; syntetiske eller naturlige forbindelser som består av kjedeformede molekyler. Disse er bygd opp av repeterende strukturelle enheter (monomerenheter, merer) dannet av mindre molekyler (monomerer).', 148150, '2018-06-22T15:35:51Z', '2018-09-04T08:44:09Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Polymer', 'Polymerer, syntetiske eller naturlige forbindelser som består av kjedeformede molekyler. Disse er bygd opp av repeterende strukturelle enheter (monomerenheter, merer) dannet av mindre molekyler (monomerer).', 148150, '2018-06-22T15:35:51Z', '2018-09-04T08:44:09Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Strømningsregime', 'Strømningsregime; beskriver fordeling og plassering av gass/væske/fast stoff som oppstår når ulike kombinasjoner av gass/væske/fast stoff strømmer sammen i en retning.', 157456, '2018-06-22T15:39:03Z', '2018-09-04T08:43:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('Strømningsregime', 'Strømningsregime; beskriver fordeling og plassering av gass/væske/fast stoff som oppstår når ulike kombinasjoner av gass/væske/fast stoff strømmer sammen i en retning.', 157456, '2018-06-22T15:39:03Z', '2018-09-04T08:43:36Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('SIWHP', 'SIWHP, engelsk; Shut in wellhead pressure. Trykket som dannes ved brønnhodet når brønnen er stengt (ikke produserer). Trykket ved brønnhodet er resultatet av reservoartrykk minus hydrostatisk trykk i produksjonsrøret.', 156207, '2018-06-22T15:39:00Z', '2018-09-04T08:43:44Z', '');
        

INSERT INTO public."concepts"("title", "content", "externalId", "created", "modified", "author")
VALUES('SIWHP', 'SIWHP, engelsk; Shut in wellhead pressure. Trykket som dannes ved brønnhodet når brønnen er stengt (ikke produserer). Trykket ved brønnhodet er resultatet av reservoartrykk minus hydrostatisk trykk i produksjonsrøret.', 156207, '2018-06-22T15:39:00Z', '2018-09-04T08:43:44Z', '');
        
