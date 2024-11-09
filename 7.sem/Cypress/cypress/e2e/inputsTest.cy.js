describe('Inputs Tests', () => {
    it('Should load the Inputs page and verify the page title', () => {
        cy.visit('https://the-internet.herokuapp.com/inputs');
        cy.contains('Inputs').should('be.visible');
    });

    it('Should type a number in the input field', () => {
        cy.visit('https://the-internet.herokuapp.com/inputs');
        cy.get('input[type="number"]').type('5').should('have.value', '5');
    });
});