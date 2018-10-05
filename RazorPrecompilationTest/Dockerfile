FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["RazorPrecompilationTest/RazorPrecompilationTest.csproj", "RazorPrecompilationTest/"]
RUN dotnet restore "RazorPrecompilationTest/RazorPrecompilationTest.csproj"
COPY . .
WORKDIR "/src/RazorPrecompilationTest"
RUN dotnet build "RazorPrecompilationTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RazorPrecompilationTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RazorPrecompilationTest.dll"]