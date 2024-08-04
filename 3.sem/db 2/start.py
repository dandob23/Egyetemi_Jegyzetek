import os
import oracledb
import dotenv

dotenv.load_dotenv()

with oracledb.connect(
    user = "BL7VQV",
    password=os.getenv("ORACLE_PASSWORD"),
    dsn="oradb.galaktika.solutions:80/oraclpdb1",
    ) as connection:
        with connection.cursor() as cursor:
            pass
