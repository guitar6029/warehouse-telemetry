up:
	docker compose up --build

down:
	docker compose down

logs:
	docker compose logs -f

ps:
	docker compose ps

migration:
	docker compose run --rm --entrypoint dotnet api ef migrations add $(name)

migrate:
	docker compose run --rm --entrypoint dotnet api ef database update
