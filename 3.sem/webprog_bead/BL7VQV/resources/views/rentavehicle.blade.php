<form action="{{ route('addMoney') }}" method="POST">
    @csrf
    <label for="money">Hozzáadni kívánt érték:</label>
    <input type="number" name="money" id="money">
    <input type="submit" value="Hozzáad">
</form>


//addmoney a profilhoz