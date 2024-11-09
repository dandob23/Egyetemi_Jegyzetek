describe('Dropdown List Tests', () => {
    it('Should load the Dropdown List page and verify dropdown functionality', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.contains('Dropdown List').should('be.visible');
    });

    it('Should verify that no option is selected by default', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.get('#dropdown').should('have.value', null);
    });

    it('Should select Option 1 from the dropdown', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.get('#dropdown').select('Option 1').should('have.value', '1');
    });

    it('Should select Option 2 from the dropdown', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.get('#dropdown').select('Option 2').should('have.value', '2');
    });
});