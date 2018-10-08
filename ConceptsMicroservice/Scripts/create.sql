
    CREATE TABLE public."concept_metas"
    (
        "Data" jsonb,
        "Id" serial primary key,
        "Created" timestamp NOT NULL,
        "Modified" timestamp NOT NULL
    );
    

    CREATE TABLE public."concepts"
    (
        "Id" serial primary key,
        "MetadataId" INTEGER  REFERENCES public."concept_metas"("Id"),
        "Created" timestamp NOT NULL ,
        "Modified" timestamp NOT NULL,
        "Title" varchar NOT NULL,
        "Content" text NOT NULL,
        "ExternalId" INTEGER NOT NULL,
        "Author" varchar NOT NULL
    );
    
