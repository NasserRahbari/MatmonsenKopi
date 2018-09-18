FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
EXPOSE 5000
COPY ["ConceptsMicroservice/ConceptsMicroservice.csproj", "ConceptsMicroservice/"]
RUN dotnet restore "ConceptsMicroservice/ConceptsMicroservice.csproj"
COPY . .
WORKDIR "/src/ConceptsMicroservice"
RUN dotnet build "ConceptsMicroservice.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ConceptsMicroservice.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ConceptsMicroservice.dll"]