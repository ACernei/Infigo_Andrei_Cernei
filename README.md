# applicant_test

## Usage


Download [docker-compose.yml](./docker-compose.yml) file.

---

Create the following empty directories:
 - `./data`
 - `./log`
 - `./secrets`

Linux:
```sh
mkdir data/ secrets/ log/
```
add permissions:
```sh
sudo chmod -R 777 ./data ./log ./secrets
```
Windows: 
```sh
mkdir data, log, secrets 
```
---

Download [init](./init) directory

It contains the `entrypoint.sh` and `init.sql` files.

---

### The final folder structure should look like this:
```
|
├── data/
├── init/
│   ├── entrypoint.sh
│   └── init.sql
├── logs/
├── secrets/
└── docker-compose.yml
```

---

Open in terminal the path where the `docker-compose.yml` file is located.

Run the following commands:
```sh
docker compose pull
```
```sh
docker compose up
```

Based on the [docker-compose.yml](./docker-compose.yml) the app will be available on http://localhost:5074/.