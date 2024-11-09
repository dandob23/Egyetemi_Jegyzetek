describe('Basic Auth Tests', () => {
    
    it('Should display the welcome message for valid credentials', () => {
        cy.visit('https://the-internet.herokuapp.com/basic_auth', {
            auth: { username: 'admin', password: 'admin' }
        });
        cy.contains('Congratulations! You must have the proper credentials.').should('be.visible');
    });

    it('Should show Not authorized if canceled', () => {
        cy.visit('https://admin:wrongpass@the-internet.herokuapp.com/basic_auth', { failOnStatusCode: false });
        cy.contains('Not authorized').should('be.visible');
    });

});