
    DROP TABLE IF EXISTS public."concepts";
    DROP TABLE IF EXISTS public."concept_metas";
    

    CREATE TABLE public."concept_metas"
    (
        "data" jsonb,
        "id" serial primary key,
        "created" timestamp NOT NULL,
        "modified" timestamp NOT NULL
    );
    

    CREATE TABLE public."concepts"
    (
        "id" serial primary key,
        "metadataId" INTEGER  REFERENCES public."concept_metas"("id"),
        "created" timestamp NOT NULL ,
        "modified" timestamp NOT NULL,
        "title" varchar NOT NULL,
        "content" text NOT NULL,
        "externalId" INTEGER NOT NULL,
        "author" varchar NOT NULL
    );
    
