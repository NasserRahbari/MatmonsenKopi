
    DROP TABLE IF EXISTS public."concepts";
    DROP TABLE IF EXISTS public."concept_metas";
    

    CREATE TABLE public."concept_metas"
    (
        "data" JSONB,
        "id" SERIAL PRIMARY KEY,
        "isActive" BOOLEAN NOT NULL,
        "created" TIMESTAMP NOT NULL,
        "modified" TIMESTAMP NOT NULL
    );
    

    CREATE TABLE public."concepts"
    (
        "id" SERIAL PRIMARY KEY,
        "metadataId" INTEGER  REFERENCES public."concept_metas"("id"),
        "created" TIMESTAMP NOT NULL ,
        "modified" TIMESTAMP NOT NULL,
        "title" VARCHAR NOT NULL,
        "content" TEXT NOT NULL,
        "externalId" INTEGER NOT NULL,
        "author" VARCHAR NOT NULL
    );
    
